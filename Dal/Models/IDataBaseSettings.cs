using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal.Models
{
    public interface IDataBaseSettings
    {
        string ConnectionString { get; set; } //משתנה שיכיל את הכתובת של הדטה בייס 

        string DatabaseName { get; set; } //משתנה שיכיל את השם של הדטה בייס

        string CollectionName { get; set; } //משתנה שיכיל את השם של הטבלה בדטה בייס

    }
}
