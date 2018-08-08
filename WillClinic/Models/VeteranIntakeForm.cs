using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WillClinic.Models
{
    public class VeteranIntakeForm
    {

        public int ID { get; set; }
        public string VeteranApplicationUserId { get; set; }
        public Veteran Veteran { get; set; }
        public byte CurrentStep { get; set; }
        public DateTime TimeStamp { get; set; }
        public bool? IsCompleted { get; set; }
        public bool? IsNotarized { get; set; }
        public byte? SavedStep { get; set; }

        // VM0
        [Display(Name = "Terms and Conditions")]
        public bool? TermsAndConditions { get; set; }


        // VM1
        [StringLength(50)]
        [Display(Name = "Full Legal Name")]
        public string FullLegalName { get; set; }

        [StringLength(50)]
        public string Address { get; set; }

        [DataType(DataType.PhoneNumber)]
        [Display(Name = "Phone Number")]
        public string PhoneNumber { get; set; }


        // VM2
        [Display(Name = "Veteran Status")]
        public bool? VeteranStatus { get; set; }

        [Display(Name = "Proof Of Service")]
        public bool? ProofOfService { get; set; }

        [Display(Name = "Resident Status")]
        public bool? ResidentStatus { get; set; }

        [Display(Name = "Net Worth")]
        public bool? NetWorth { get; set; }


        //VM3
        [Display(Name = "Monthly Income")]
        [DataType(DataType.Currency)]
        public int MonthlyIncome { get; set; }

        [Display(Name = "Bank Account Assets")]
        [DataType(DataType.Currency)]
        public int BankAccountAssets { get; set; }

        [Display(Name = "Real Estate Assets")]
        [DataType(DataType.Currency)]
        public int RealEstateAssets { get; set; }

        [Display(Name = "Life Insurance Cash Value")]
        [DataType(DataType.Currency)]
        public int LifeInsuranceCashValue { get; set; }

        [Display(Name = "Retirement Accounts")]
        [DataType(DataType.Currency)]
        public int RetirementAccounts { get; set; }

        [Display(Name = "Stock Bonds")]
        [DataType(DataType.Currency)]
        public int StockBonds { get; set; }

        [DataType(DataType.Currency)]
        public int Pension { get; set; }

        [Display(Name = "Business Interest")]
        [DataType(DataType.Currency)]
        public int BusinessInterest { get; set; }

        [Display(Name = "Money Owed To You")]
        [DataType(DataType.Currency)]
        public int MoneyOwedToYou { get; set; }

        [Display(Name = "Other Assets Or Money")]
        [DataType(DataType.Currency)]
        public int OtherAssetsOrMoney { get; set; }


        // VM4
        [Display(Name = "House Hold Size")]
        public int HouseHoldSize { get; set; }

        [Display(Name = "Marital Status")]
        public MaritalStatus MaritalStatus { get; set; }

        [StringLength(50)]
        [Display(Name = "Full Name Spouse")]
        public string FullNameSpouse { get; set; }

        [Display(Name = "Have Children")]
        public bool? HaveChildren { get; set; }

        [Display(Name = "Under Age Children")]
        public bool? UnderAgeChildren { get; set; }

        [StringLength(50)]
        [Display(Name = "Minor Children Different Spouse")]
        public string MinorChildrenDifferentSpouse { get; set; }

        [Display(Name = "Currently Pregnant")]
        public bool? CurrentlyPregnant { get; set; }

        [Display(Name = "Specific Bequest")]
        public bool? SpecificBequest { get; set; }

        [StringLength(500)]
        [Display(Name = "Bequest Information")]
        public string BequestInfromation { get; set; }

        [Display(Name = "Inherit Estate")]
        public InheritEstate InheritEstate { get; set; }

        [StringLength(1000)]
        [Display(Name = "Inherit Estate Specific")]
        public string InheritEstateSpecific { get; set; }

        [Display(Name = "Remainer Beneficiary")]
        public RemainderBeneficiary RemainderBeneficiary { get; set; }

        [StringLength(1000)]
        [Display(Name = "Remainder Beneficiary Specific")]
        public string RemainderBeneficiarySpecific { get; set; }

        [Display(Name = "Disinherit Someone")]
        public bool? DisinheritSomeone { get; set; }

        [StringLength(75)]
        [Display(Name = "Disinheret Description")]
        public string DisinheritDescription { get; set; }

        [StringLength(50)]
        [Display(Name = "Primary Guardian")]
        public string PrimaryGuardian { get; set; }

        [StringLength(50)]
        [Display(Name = "Alternate Guardian")]
        public string AlternateGuardian { get; set; }

        [StringLength(50)]
        [Display(Name = "Personal Representative")]
        public string PersonalRepresentative { get; set; }

        [StringLength(50)]
        [Display(Name = "Alternate Representative")]
        public string AlternateRepresentative { get; set; }


        // VM5
        [Display(Name = "Request Power Of Attorney")]
        public bool? RequestPowerOfAttorney { get; set; }

        [StringLength(50)]
        [Display(Name = "Primary Attorney")]
        public string PrimaryAttorney { get; set; }

        [StringLength(50)]
        [Display(Name = "Alternate Attorney")]
        public string AlternateAttorney { get; set; }


        // VM6
        [Display(Name = "Health Care Directive")]
        public bool? HealthCareDirective { get; set; }

        [Display(Name = "Hydration Directive")]
        public bool? HydrationDirective { get; set; }

        [Display(Name = "Nutrition Directive")]
        public bool? NutritionDirective { get; set; }

        [Display(Name = "Artificial Ventilation")]
        public bool? ArtificialVentilation { get; set; }

        [Display(Name = "Distress Medication")]
        public bool? DistressMedication { get; set; }


        // VM7
        [Display(Name = "Health Power Of Attorney")]
        public bool? HealthPOA { get; set; }

        [Display(Name = "Primary Health Attorney")]
        public string PrimaryHealthAttorney { get; set; }

        [Display(Name = "Secondary Health Attorney")]
        public string SecondaryHealthAttorney { get; set; }       
    }
}