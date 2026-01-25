using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Api.ModelDto
{
    public class OrderHeaderUpdateDto
    {
        public int OrderHeaderId { get; set; }
        public string CustomerName { get; set; }
        public string CustomerEmail { get; set; }

        public string Status { get; set; }
        public IEnumerable<OrderDetailsCreateDto> OrderDetailsDto { get; set; }
    }
}