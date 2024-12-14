using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutritionalKitchen.Domain.Package
{
    public class LabelFactory : ILabelFactory
    {
        public Label Create(string batchCode, DateTime productionDate, DateTime expirationDate, Guid patientId, string detail, string address)
        {
            if (string.IsNullOrWhiteSpace(batchCode))
            {
                throw new ArgumentException("Batch code is required", nameof(batchCode));
            }

            if (productionDate == default)
            {
                throw new ArgumentException("Production date is required", nameof(productionDate));
            }

            if (expirationDate == default)
            {
                throw new ArgumentException("Expiration date is required", nameof(expirationDate));
            }

            if (patientId == Guid.Empty)
            {
                throw new ArgumentException("Patient ID is required", nameof(patientId));
            }

            return new Label(batchCode, productionDate, expirationDate, detail, address, patientId);
        }
    }

}
