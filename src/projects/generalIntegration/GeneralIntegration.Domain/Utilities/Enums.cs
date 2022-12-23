using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneralIntegration.Domain.Utilities
{
    public static class Enums
    {
        public enum FirmNr
        {
            _001_ = 1,
            _500_ = 500,
            _650_ = 650,
            _202_ = 202
        }

        public enum Period
        {
            CurrentPeriod = 15,
            LastPeriod = 14
        }

        public enum JobsPermission
        {
            AxataSum = 1,
            UpdateUInfo = 2,
            UreticiYetki = 3,
            NegativesRepair = 4,
            PassiveItemsSetActive = 5,
            GrKodUpdate = 6,
            Pricelist = 7,
            InvoicePermissionCode = 8,
            SmmKurs = 9,
            PurchaseExpireRebuild = 10,
            OrdersForBilling = 11,
            ChangeSituation7 = 12,
            ItemTransaction_11_50_51 = 13,
            AutoUpdate_12 = 14,
            AutoUpdate_25 = 15,
            AutoUpdate_2_3 = 16,
            AutoUpdate_06 = 17,
            AutoTo500 = 18,
            AutoIade01 = 19,
            PricePercent = 20,
            Item = 21,
            ClCard = 22,
            AK_202_SalesInvoices = 23,
            PharmacyBalance = 24,
            AutoUpdate_Consignment_09 = 25,
            AutoUpdate_Consignment_04 = 26,
            PriceTarif = 27,
            AutoUpdate06Sysy = 28,
            Unitset = 29,
            ReindexCheck = 30,
            AutoTransferDispatch = 31,
            Test = 32,
        }
    }
}
