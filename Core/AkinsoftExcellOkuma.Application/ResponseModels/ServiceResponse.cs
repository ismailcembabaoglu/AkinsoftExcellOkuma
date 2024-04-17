using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AkinsoftExcellOkuma.Application.ResponseModels
{
    public class ServiceResponse<T> : BaseResponse
    {
        public T Value { get; set; }
    }
}
