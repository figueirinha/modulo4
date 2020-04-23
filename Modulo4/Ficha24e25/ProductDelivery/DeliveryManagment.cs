using System;
using System.Collections.Generic;
using System.Text;

namespace Recodme.Formacao.Exercicios.Ficha24e25.ProductDelivery
{
    public struct DeliveryManagment
    {
        public DateTime ReceiptDate { get; }
        public long Nif { get; }
        public DateTime ArrivalDate { get; }

        public DeliveryManagment(DateTime receiptDate, long nif, DateTime arrivalDate)
        {
            ReceiptDate = receiptDate;
            Nif = nif;
            ArrivalDate = arrivalDate;
        }

    }
}
