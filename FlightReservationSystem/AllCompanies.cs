using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace FlightReservationSystem
{
    class AllCompanies
    {
        public AllCompanies()
        {

        }

        public void Update()
        {
            companies.Clear();

            DataTable companyTable = DBFacade.GetCompanies();

            for (int i = 0; i < companyTable.Rows.Count; i++)
            {
                Guid ID = Guid.Parse(companyTable.Rows[i]["ID"].ToString());
                String name = companyTable.Rows[i]["Name"].ToString();
                companies.Add(new Company(ID,name));
            }
            
        }

        public void AddCompany(Company company)
        {
            companies.Add(company);
        }

        List<Company> companies = new List<Company>();
    }

}
