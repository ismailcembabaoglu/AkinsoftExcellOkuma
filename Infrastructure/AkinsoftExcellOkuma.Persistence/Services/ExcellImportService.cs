using AkinsoftExcellOkuma.Application.DTOs;
using AkinsoftExcellOkuma.Application.IServices;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

using AkinsoftExcellOkuma.Persistence.Utils;

namespace AkinsoftExcellOkuma.Persistence.Services
{
    public class ExcellImportService : IExcellImportService
    {
        HttpClient client;
        public ExcellImportService()
        {
            client = new HttpClient();
        }

        public async Task< List<TatilDTO>> GetCleanders(int year,int month)
        {
            var cleanderGet= await client.GetServiceResponseAsync<List<CleanderDTO>>("https://script.googleusercontent.com/macros/echo?user_content_key=Zw2T0plgDKxdEH6Ld3MsHJnjQdYTZ50NAFyZpZxgeCdDeGr5xPjjKMv2GHtQHhegdIesgK097xNQfPrsP4yVJH-ad_oZDuHOm5_BxDlH2jW0nuo2oDemN9CCS2h10ox_1xSncGQajx_ryfhECjZEnBJmqZ7aCXgr_T9raHPdKD6FzJhOrtBk09Ompd0XWIbEdnRLihd5L-SribzJCTkISQa9gIUwtEVBJ4l_9wfuv83zfNqxja1jVw&lib=MuYsjupAABHnb8YXhYhaAABxIoJWoTElh");
            List<TatilDTO> tatils = new List<TatilDTO>();
            foreach (var cleander in cleanderGet)
            {

                DateTime date = DateTime.Parse(cleander.localeDateString);
                if (date.Month==month && date.Year==year)
                {
                    TatilDTO tatil = new TatilDTO
                    {
                        Ay = date.Month,
                        Gun = date.Day,
                        Yıl = date.Year,
                    };

                    tatils.Add(tatil);
                }
             
            }
            return tatils;
        }

        public async  Task<List<DayDTO>> GetExcellPuantajs(DayIndexDTO dayIndex)
        {
            List<DayDTO> list = new List<DayDTO>();
            string filePath = Path.Combine(Directory.GetCurrentDirectory(),$"uploads/{dayIndex.PathName}");
            FileInfo fileInfo = new FileInfo(filePath);
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            using (ExcelPackage excelPackage = new ExcelPackage(fileInfo))
            {
                ExcelWorksheet worksheet =  excelPackage.Workbook.Worksheets.FirstOrDefault();
                int totalCollumn = worksheet.Dimension.End.Column;
                int totalRow = worksheet.Dimension.End.Row;
                for (int row = 2; row <= totalRow; row++)
                {
                    DayDTO excellDTO = new DayDTO();
                   
                        excellDTO.SicilNo = worksheet.Cells[row, dayIndex.SicilNo]?.Value?.ToString();
                         excellDTO.AyKodu = (short)Convert.ToInt32( worksheet.Cells[row, dayIndex.AyKodu]?.Value);
                        excellDTO.IsyeriKodu = worksheet.Cells[row, dayIndex.IsyeriKodu]?.Value?.ToString();
                       excellDTO.IsyeriAdi = worksheet.Cells[row, dayIndex.IsyeriAdi]?.Value?.ToString();
                    excellDTO.CL = Convert.ToInt32(worksheet.Cells[row, dayIndex.CL]?.Value);
                    excellDTO.HS = Convert.ToInt32(worksheet.Cells[row, dayIndex.HS]?.Value);
                    excellDTO.GT = Convert.ToInt32(worksheet.Cells[row, dayIndex.GT]?.Value);
                    excellDTO.RP = Convert.ToInt32(worksheet.Cells[row, dayIndex.RP]?.Value);
                    excellDTO.UL = Convert.ToInt32(worksheet.Cells[row, dayIndex.UL]?.Value);
                    excellDTO.UZ = Convert.ToInt32(worksheet.Cells[row, dayIndex.UZ]?.Value);
                    excellDTO.YL = Convert.ToInt32(worksheet.Cells[row, dayIndex.YL]?.Value);
                    excellDTO.GM = Convert.ToInt32(worksheet.Cells[row, dayIndex.GM]?.Value);
                    excellDTO.EksikGun = worksheet.Cells[row, dayIndex.EksikGun]?.Value?.ToString();
                    excellDTO.ToplamPrimGun = ((short)Convert.ToInt32(worksheet.Cells[row, dayIndex.ToplamPrimGun]?.Value));
                    excellDTO.ToplamUcretGun = ((short)Convert.ToInt32(worksheet.Cells[row, dayIndex.ToplamUcretGun]?.Value));
                    excellDTO.MESAI_HFICI_PNC = Convert.ToDouble(worksheet.Cells[row, dayIndex.MESAI_HFICI_PNC]?.Value);
                    excellDTO.MESAI_HFSN_PNC = Convert.ToDouble(worksheet.Cells[row, dayIndex.MESAI_HFSN_PNC]?.Value);
                    excellDTO.MESAI_BYRM_PNC = Convert.ToDouble(worksheet.Cells[row, dayIndex.MESAI_BYRM_PNC]?.Value);
                    excellDTO.MESAI_HFICI_GECE_PNC = Convert.ToDouble(worksheet.Cells[row, dayIndex.MESAI_HFICI_GECE_PNC]?.Value);
                    excellDTO.MESAI_HFSN_GECE_PNC = Convert.ToDouble(worksheet.Cells[row, dayIndex.MESAI_HFSN_GECE_PNC]?.Value);
                    excellDTO.MESAI_BYRM_GECE_PNC = Convert.ToDouble(worksheet.Cells[row, dayIndex.MESAI_BYRM_GECE_PNC]?.Value);
                    excellDTO.TOPLAM_UZAKTAN_CALISMA = ((short)Convert.ToInt32(worksheet.Cells[row, dayIndex.TOPLAM_UZAKTAN_CALISMA]?.Value));
                    list.Add(excellDTO);
                }
            }
            return list;
        }

        public List<TatilDTO> GetTatils(int year, int month)
        {
     
            List<TatilDTO> tatils= new List<TatilDTO>();
            
            // Belirtilen yıl ve ay için bir DateTime nesnesi oluşturun
            DateTime startDate = new DateTime(year, month, 1);
            int daysInMonth = DateTime.DaysInMonth(year, month);

            // Ay içindeki her gün için döngü
            for (int day = 1; day <= daysInMonth; day++)
            {
                DateTime currentDate = new DateTime(year, month, day);

                // Eğer gün Cumartesi veya Pazar ise hafta sonu olarak kabul edilir
                if (currentDate.DayOfWeek == DayOfWeek.Saturday || currentDate.DayOfWeek == DayOfWeek.Sunday)
                {
                    TatilDTO tatil = new TatilDTO();
                    tatil.Ay = month;
                    tatil.Yıl = year;
                    tatil.Gun = day;
                    tatils.Add(tatil);
                }
            }
            return tatils;
        }
    }
}
