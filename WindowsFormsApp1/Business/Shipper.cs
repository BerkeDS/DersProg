namespace WindowsFormsApp1.Business
{
    class Shipper
    {
        public int shipper_id { get; set; }
        public string company_name { get; set; }
        public string phone_number { get; set; }

        public Shipper()
        {

        }

        public Shipper(int shipperid,string companyname,string phonenumber)
        {
            shipper_id = shipperid;
            company_name = companyname;
            phone_number = phonenumber;
        }

    }
}
