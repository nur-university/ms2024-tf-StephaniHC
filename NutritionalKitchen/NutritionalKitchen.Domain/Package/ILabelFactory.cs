using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutritionalKitchen.Domain.Package
{
    public interface ILabelFactory
    {
        Label Create(string batchCode, DateTime productionDate, DateTime expirationDate, Guid patientId, string detail, string address);
    }

}
