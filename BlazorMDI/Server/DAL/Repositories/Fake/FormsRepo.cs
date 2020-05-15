using BlazorMDI.Server.DAL.Interfaces;
using BlazorMDI.Shared.GridData;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Threading.Tasks;

namespace BlazorMDI.Server.DAL.Repositories.Fake
{
    public class FormsRepo: IFormsRepo
    {
        public Task<IEnumerable<FormMgmtGrid>> GetFormsList(string appName)
        {
            var rnd = new Random();
            var myTI = new CultureInfo("en-US", false).TextInfo;
            var res = new List<FormMgmtGrid>();

            var max = rnd.Next(10, 30);
            for (int i = 0; i < max; i++)
            {
                var name = myTI.ToTitleCase(LoremNET.Lorem.Words(2, 3));
                var sname = name.Replace(" ", "");

                res.Add(new FormMgmtGrid
                    {
                        Id = Guid.NewGuid(),
                        Name = $"frm{sname}",
                        Title = name,
                        ObjectName = $"App.{appName}.FormObject.{sname}DS",
                        LastModified = DateTime.Today.AddHours(-rnd.Next(1, 500))
                    }
                );
            }

            return Task.FromResult<IEnumerable<FormMgmtGrid>>(res);
        }
    }
}
