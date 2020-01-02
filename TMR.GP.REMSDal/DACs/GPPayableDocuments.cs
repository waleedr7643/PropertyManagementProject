using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using Microsoft.Dexterity.Bridge;
using Microsoft.Dexterity.Applications.DynamicsDictionary;
using Microsoft.Dexterity.Applications;

namespace TMR.GP.REMSDal
{
    public partial class DataAccess
    {
        public bool AddPMTransHeader(PMPurchaseDocument document, string VoucherNumber)
        {
            TableError err;

            PmTransactionWorkTable pms;
            pms = Dynamics.Tables.PmTransactionWork;

            pms.VoucherNumberWork.Value = VoucherNumber;
            pms.DocumentDate.Value = Dynamics.Globals.UserDate.Value;
            pms.DocumentNumber.Value = document.DocumentNumber;
            pms.TransactionDescription.Value = document.TransactionDescription;
            pms.VoucherNumber.Value = VoucherNumber;
            pms.VendorId.Value = document.VendNumber;
            pms.CurrencyId.Value = document.CurrencyId;
            pms.BatchNumber.Value = document.BatchNumber;
            pms.TaxEngineCalled.Value = document.TaxEngineCalled;
            pms.BatchSource.Value = document.BatchSource;//"RM_Sales";
            pms.DocumentType.Value = (short)document.DocumentType;// 7;            
            pms.DocumentAmount.Value = document.AccountAmount;
            pms.PurchasesAmount.Value = document.AccountAmount;
            pms.ChargeAmount.Value = document.AccountAmount;
            pms.PostingDate.Value = Dynamics.Globals.UserDate.Value;
            pms.PostingStatus.Value = 20;
            pms.CurrentTrxAmount.Value = document.AccountAmount;

            try { err = pms.Save(); }
            catch { return false; }
            finally { pms.Close(); }

            return true;
        }
        public bool AddPMNumberSequence(string voucherNumber, string DocNumber, string VendorID)
        {
            TableError err;

            PmKeyMstrTable kmt;
            kmt = Dynamics.Tables.PmKeyMstr;

            kmt.BatchSource.Value = "PM_Trxent";
            kmt.ControlNumber.Value = voucherNumber;
            kmt.VendorId.Value = VendorID;
            kmt.DocumentNumber.Value = DocNumber;
            kmt.DocumentStatus.Value = 1;
            kmt.DocumentType.Value = 1;
            kmt.DocumentDate.Value = Dynamics.Globals.UserDate.Value;
            kmt.UserId.Value = Dynamics.Globals.UserId.Value;

            try { err = kmt.Save(); }
            catch { return false; }
            finally { kmt.Close(); }

            return true;



        }
        public bool AddPMTransDistributions(PMPurchaseDocument document, string VoucherNumber)
        {
            TableError err;
            foreach (var distribution in document.Distributions)
            {
                PmDistributionWorkOpenTable rdwt1;
                rdwt1 = Dynamics.Tables.PmDistributionWorkOpen;

                rdwt1.PostingStatus.Value = distribution.PostingStatus;//3
                rdwt1.VoucherNumber.Value = VoucherNumber;
                rdwt1.DistributionType.Value = distribution.DistributionType;//17;

                rdwt1.DistributionSequenceNumber.Value = distribution.SequenceNumber;
                rdwt1.VendorId.Value = distribution.VendorNumber;
                rdwt1.DistributionAccountIndex.Value = distribution.DistributionAccountIndex;
                rdwt1.DebitAmount.Value = distribution.DebitAmount;
                rdwt1.CreditAmount.Value = distribution.CreditAmount;
                rdwt1.CurrencyId.Value = distribution.CurrencyId;//"Z-US$";
                rdwt1.CurrencyIndex.Value = distribution.CurrencyIndex;//1007;

                rdwt1.ExchangeRate.Value = 1;
                rdwt1.IcCurrencyIndex.Value = distribution.CurrencyIndex;//1007;
                rdwt1.IcCurrencyId.Value = distribution.CurrencyId;//"Z-US$";
                rdwt1.DecimalPlaces.Value = 2;

                rdwt1.DistributionReference.Value = distribution.DistributionReference;
                rdwt1.IntercompanyId.Value = Dynamics.Globals.IntercompanyId.Value;
                try { err = rdwt1.Save(); }
                catch { return false; }
                finally { rdwt1.Close(); }
            }
            return true;
        }
    }
}