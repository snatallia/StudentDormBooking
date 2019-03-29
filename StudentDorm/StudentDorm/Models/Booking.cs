using GridMvc.DataAnnotations;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Linq.Expressions;
using System.Web;
using System.Web.Mvc;

namespace StudentDorm.Models
{
    public class Booking
    {
        public int ID { get; set; }
        public int RoomID { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        [GridColumn(Title = "Start Date", Width = "100px", Format = "{0:dd.MM.yyyy}")]
        public DateTime StartDate { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime EndDate { get; set; }

        public int UsedPlaces { get; set; }
        public short Gender { get; set; }


        //public static MvcHtmlString DatePickerFor<TModel>(this HtmlHelper<TModel> htmlHelper, Expression<Func<TModel, DateTime>> expression, string controlId, string title)
        //{
         
        //    Func<TModel, DateTime> method = expression.Compile();
        //    var date = method(htmlHelper.ViewData.Model);
        //    var str = $"<div class=\"col-md-10\"><a href=\"javascript:;\" id=\"{controlId}\" data-type=\"date\" data-viewformat=\"yyyy-mm-dd\" data-pk=\"1\" data-placement=\"right\" data-original-title=\"{title}\">{date.ToString("yyyy-MM-dd")}</a></div>";
        //    return new MvcHtmlString(str);
        //}
    }


}