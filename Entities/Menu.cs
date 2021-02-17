
namespace EMS.Entities
{
    public class Menu
    {
        public int Id { get; set; }        
        public int MenuType { get; set; }

        public int AppUserId { get; set; }
        public AppUser AppUser { get; set; }
        

    }

    //public enum MenuType
    //{
    //    CRM = 1,
    //    Calendar = 2,
    //    Master_Entry = 3,
    //    Manage_Advance_Fields = 4,
    //    Location = 5,
    //    Country_Name_Code = 6,
    //    Discount= 7,
    //    Price_Type = 8,
    //    Account_Manager = 9,
    //    Category_Master =10,
    //    Address_Book = 11,
    //    Add_Company = 12,
    //    Search = 13,
    //    Relation_Type_Master = 14
    //}
}