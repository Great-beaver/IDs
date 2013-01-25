using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;
using System.ComponentModel;

namespace IDbase.Models
{
    [MetadataType(typeof(IdMetadata))]
    public partial class IDtable
    {
        [Bind(Exclude="IDnumber")]
        public class IdMetadata
        {
            [ScaffoldColumn(false)]
            public int IDnumber {get; set;}

            [DisplayName("Имя")]
            [Required(ErrorMessage="Поле 'Имя' является обязательным")]
            [DisplayFormat(ConvertEmptyStringToNull=false)]
            [StringLength(50,ErrorMessage="Поле 'Имя' может содержать до 50 символов")]
            public string FirstName { get; set; }

            [DisplayName("Фамилия")]
            [Required(ErrorMessage = "Поле 'Фамилия' является обязательным")]
            [DisplayFormat(ConvertEmptyStringToNull = false)]
            [StringLength(50, ErrorMessage = "Поле 'Фамилия' может содержать до 50 символов")]
            public string LastName { get; set; }
            
            
            [DisplayName("Дата рождения")]
            [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}", ApplyFormatInEditMode=true)]
            public string DateOfBirth { get; set; }

            [DisplayName("Дата выдачи")]
            [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}", ApplyFormatInEditMode = true)]
            public string Since { get; set; }

            [DisplayName("Действителен до")]
            [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}", ApplyFormatInEditMode = true)]
            public string Expire { get; set; }

            [DisplayName("Место рождения")]
            [DisplayFormat(ConvertEmptyStringToNull = false)]
            [StringLength(50)]
            public string PlaceOfBirth { get; set; }

            [DisplayName("Пол")]
            public string Sex { get; set; }


        }
    }
}