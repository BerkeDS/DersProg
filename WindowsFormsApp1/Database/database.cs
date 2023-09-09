namespace WindowsFormsApp1.Database
{
    public class database
    {
        public static string get_con_string
        {
            get { return "server=DESKTOP-M8NF4AB\\SQLEXPRESS; Initial Catalog=Northwind; Integrated Security=SSPI"; }
        }
        public static string prog_baglanti
        {
            get
            {
                return @"server=DESKTOP-M8NF4AB\SQLEXPRESS; Initial Catalog=Program; Integrated Security=SSPI";
            }
        }

        public static string okul_baglanti
        {
            get
            {
                return @"server=A222-41; Initial Catalog=Program; Integrated Security=SSPI";
            }
        }
    }
}
