using GridMvc.DataAnnotations;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace StudentDorm.Models
{
    public class Booking
    {
        public int ID { get; set; }
        public int RoomID { get; set; }

        //[DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}", ApplyFormatInEditMode = true)]
        [GridColumn(Title = "Start Date", Width = "120px", Format = "{0:dd/MM/yyyy}",  FilterEnabled = true)]
        public DateTime StartDate { get; set; }

        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}", ApplyFormatInEditMode = true)]
        public DateTime EndDate { get; set; }
        public int UsedPlaces { get; set; }
        public short Gender { get; set; }
    }
}