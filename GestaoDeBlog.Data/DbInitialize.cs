using System;
using System.Collections.Generic;
using System.Text;

namespace GestaoDeBlog.Data
{
    public class DbInitialize
    {
        public static void Initialize(PostContext context)
        {
            context.Database.EnsureCreated();
        }
    }
}
