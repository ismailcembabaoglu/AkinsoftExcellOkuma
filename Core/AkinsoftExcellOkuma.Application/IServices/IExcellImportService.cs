﻿using AkinsoftExcellOkuma.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AkinsoftExcellOkuma.Application.IServices
{
    public interface IExcellImportService
    {
        Task<List<DayDTO>> GetExcellPuantajs(DayIndexDTO dayIndex);
        Task<List<BordroDTO>> GetExcellBordros(BordroIndexDTO dayIndex);
        List<TatilDTO> GetTatils(int year, int month);
        Task<List<TatilDTO>> GetCleanders(int year, int month);
    }
}
