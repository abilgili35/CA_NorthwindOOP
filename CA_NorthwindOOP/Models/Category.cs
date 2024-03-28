using CA_NorthwindOOP.Abstracts;

namespace CA_NorthwindOOP.Models
{
    public class Category:BaseClass
    {
        
        public string CategoryName { get; set; }
        public string Description { get; set; }

        public override string ToString()
        {
            return $"{CategoryName}  -  Id : {Id}  -  Aciklama : {Description}";
        }
    }
}
