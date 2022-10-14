using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryLayer.Models
{
    public class EmployeeDA
    {
        private readonly EmployeeContext context;

        public EmployeeDA(EmployeeContext employee)
        {
            context = employee;
        }

        public List<Tblemployee> GetAll()
        {
            //return context.Tblemployees.FromSqlRaw("exec SP_Customer").ToList();
            return context.Tblemployees.ToList();
        }
        public List<Designation> GetAlldesig()
        {
            return context.Designations.ToList();

        }
        public Tblemployee GetByCode(int code)
        {
            return context.Tblemployees.FirstOrDefault(x => x.Code == code);
        }

        public string Remove(int code)
        {
            string result = string.Empty;
            var employee = context.Tblemployees.FirstOrDefault(x => x.Code == code);
            if (employee != null)
            {
                context.Tblemployees.Remove(employee);
                context.SaveChanges();
                result = "pass";
            }
            return result;
        }

        public string save(Tblemployee tblemployee)
        {
            string result = string.Empty;
            var employee = context.Tblemployees.FirstOrDefault(x => x.Code == tblemployee.Code);
            if (employee != null)
            {
                employee.Code = tblemployee.Code;
                employee.Name = tblemployee.Name;
                employee.Email = tblemployee.Email;
                employee.Phone = tblemployee.Phone;
                employee.Dcode = tblemployee.Dcode;
                context.SaveChanges();
                result = "pass";
            }
            else
            {
                Tblemployee d = new Tblemployee()
                {
                    Code = tblemployee.Code,
                    Name = tblemployee.Name,
                    Email = tblemployee.Email,
                    Phone = tblemployee.Phone,
                    Dcode = tblemployee.Dcode,

                };
                context.Tblemployees.Add(d);
                context.SaveChanges();
                result = "pass";
            }
            return result;
        }
    }
}
