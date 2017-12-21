using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using bll;
using interfaces;

namespace Dealership.Models
{
    public class Repo
    {

        public static IBLL repo = new Logic();

    }
}