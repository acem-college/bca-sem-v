using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infant.Application.Models.Infants
{
    public class InfantVM
    {
        public Guid Id { get; set; }
        public string Heading { get; set; }
        public string PageTitle { get; set; }
        public string PageContent { get; set; }
        public string ShortDescription { get; set; }
        public string FeaturedImageUrl { get; set; }
        public string UrlHandler { get; set; }
        public DateTime PublishedDate{ get; set; }
        public string Writer { get; set; }
        public bool Visible {  get; set; }
    }
}
