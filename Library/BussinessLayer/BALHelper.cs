﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;

namespace BussinessLayer
{
    public class BALHelper
    {
        public DataTable GetGenderType()
        {
            string query = "select * from Gender";
            DataTable dt = new DataTable();
            dt = DAO.GetTable(query, null, CommandType.Text);
            try
            {
                if (dt != null)
                {
                    return dt;
                }
                return null;
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
