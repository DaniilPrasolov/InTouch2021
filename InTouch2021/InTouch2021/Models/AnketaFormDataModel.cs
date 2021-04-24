using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace InTouch2021.Models
{
    public class AnketaFormDataModel
    {

        private readonly float [] kofAr = { 0, 0.5f, 1 };

        [Key]

        public int id { get; set; }



    }
}
