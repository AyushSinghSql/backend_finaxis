using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace PlanningAPI.Models;

public partial class PlEmployee
{
    public string EmplId { get; set; } = null!;

    public string? OrgId { get; set; }

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public string? MidName { get; set; }

    public string? Role { get; set; }

    public string? Email { get; set; } = null!;

    public string? Ln1Adr { get; set; }

    public string? Ln2Adr { get; set; }

    public string? Ln3Adr { get; set; }

    public string? MailStateDc { get; set; }

    public string? PostalCd { get; set; }

    public string? CountyName { get; set; }

    public string? PhoneNumber { get; set; }

    public string? MaritalCd { get; set; }

    public string? Gender { get; set; }

    public DateOnly? HireDate { get; set; }

    public string? PlcGlcCode { get; set; }

    public decimal? PerHourRate { get; set; }

    public decimal? Salary { get; set; }

    public string? AccId { get; set; }
    public string? Type { get; set; }

    public bool IsRev { get; set; }

    public bool IsBrd { get; set; }

    public DateTime? CreatedAt { get; set; }
    [JsonIgnore]
    public virtual Organization? Org { get; set; }
    
    public virtual ICollection<PlForecast> PlForecasts { get; set; } = new List<PlForecast>();
}

[Table("empl")]
public class EmployeeMaster
{
    [Key]
    [Column("empl_id")]
    public string EmplId { get; set; } = null!;

    [Column("lv_pd_cd")]
    public string? LvPdCd { get; set; }

    [Column("taxble_entity_id")]
    public string? TaxbleEntityId { get; set; }

    [Column("ssn_id")]
    public string? SsnId { get; set; }

    [Column("orig_hire_dt")]
    public DateTime? OrigHireDt { get; set; }

    [Column("adj_hire_dt")]
    public DateTime? AdjHireDt { get; set; }

    [Column("term_dt")]
    public DateTime? TermDt { get; set; }

    [Column("s_empl_status_cd")]
    public string? SEmplStatusCd { get; set; }

    [Column("spvsr_name")]
    public string? SpvsrName { get; set; }

    [Column("last_name")]
    public string? LastName { get; set; }

    [Column("first_name")]
    public string? FirstName { get; set; }

    [Column("mid_name")]
    public string? MidName { get; set; }

    [Column("pref_name")]
    public string? PrefName { get; set; }

    [Column("name_prfx_cd")]
    public string? NamePrfxCd { get; set; }

    [Column("name_sfx_cd")]
    public string? NameSfxCd { get; set; }

    [Column("notes")]
    public string? Notes { get; set; }

    [Column("ts_pd_cd")]
    public string? TsPdCd { get; set; }

    [Column("birth_dt")]
    public DateTime? BirthDt { get; set; }

    [Column("city_name")]
    public string? CityName { get; set; }

    [Column("country_cd")]
    public string? CountryCd { get; set; }

    [Column("last_first_name")]
    public string? LastFirstName { get; set; }

    [Column("ln_1_adr")]
    public string? Ln1Adr { get; set; }

    [Column("ln_2_adr")]
    public string? Ln2Adr { get; set; }

    [Column("ln_3_adr")]
    public string? Ln3Adr { get; set; }

    [Column("mail_state_dc")]
    public string? MailStateDc { get; set; }

    [Column("postal_cd")]
    public string? PostalCd { get; set; }

    [Column("modified_by")]
    public string? ModifiedBy { get; set; }

    [Column("time_stamp")]
    public DateTime? TimeStamp { get; set; }

    [Column("locator_cd")]
    public string? LocatorCd { get; set; }

    [Column("prir_name")]
    public string? PrirName { get; set; }

    [Column("company_id")]
    public string? CompanyId { get; set; }

    [Column("last_review_dt")]
    public DateTime? LastReviewDt { get; set; }

    [Column("next_review_dt")]
    public DateTime? NextReviewDt { get; set; }

    [Column("sex_cd")]
    public string? SexCd { get; set; }

    [Column("marital_cd")]
    public string? MaritalCd { get; set; }

    [Column("elig_auto_pay_fl")]
    public bool? EligAutoPayFl { get; set; }

    [Column("email_id")]
    public string? EmailId { get; set; }

    [Column("mgr_empl_id")]
    public string? MgrEmplId { get; set; }

    [Column("s_race_cd")]
    public string? SRaceCd { get; set; }

    [Column("pr_serv_empl_id")]
    public string? PrServEmplId { get; set; }

    [Column("county_name")]
    public string? CountyName { get; set; }

    [Column("ts_pd_reg_hrs_no")]
    public decimal? TsPdRegHrsNo { get; set; }

    [Column("pay_pd_reg_hrs_no")]
    public decimal? PayPdRegHrsNo { get; set; }

    [Column("disabled_fl")]
    public bool? DisabledFl { get; set; }

    [Column("mos_review_no")]
    public int? MosReviewNo { get; set; }

    [Column("cont_name_1")]
    public string? ContName1 { get; set; }

    [Column("cont_name_2")]
    public string? ContName2 { get; set; }

    [Column("cont_phone_1")]
    public string? ContPhone1 { get; set; }

    [Column("cont_phone_2")]
    public string? ContPhone2 { get; set; }

    [Column("cont_rel_1")]
    public string? ContRel1 { get; set; }

    [Column("cont_rel_2")]
    public string? ContRel2 { get; set; }

    [Column("union_empl_fl")]
    public bool? UnionEmplFl { get; set; }

    [Column("visa_type_cd")]
    public string? VisaTypeCd { get; set; }

    [Column("vet_status_s")]
    public bool? VetStatusS { get; set; }

    [Column("vet_status_v")]
    public bool? VetStatusV { get; set; }

    [Column("vet_status_o")]
    public bool? VetStatusO { get; set; }

    [Column("vet_status_r")]
    public bool? VetStatusR { get; set; }

    [Column("ess_pin_id")]
    public string? EssPinId { get; set; }

    [Column("pin_updated_fl")]
    public bool? PinUpdatedFl { get; set; }

    [Column("s_ess_cos_cd")]
    public string? SEssCosCd { get; set; }

    [Column("home_email_id")]
    public string? HomeEmailId { get; set; }

    [Column("rowversion")]
    public byte[]? Rowversion { get; set; }

    [Column("vet_release_dt")]
    public DateTime? VetReleaseDt { get; set; }

    [Column("contractor_fl")]
    public bool? ContractorFl { get; set; }

    [Column("blind_fl")]
    public bool? BlindFl { get; set; }

    [Column("visa_dt")]
    public DateTime? VisaDt { get; set; }

    [Column("vet_status_d")]
    public bool? VetStatusD { get; set; }

    [Column("vet_status_a")]
    public bool? VetStatusA { get; set; }

    [Column("time_entry_type")]
    public string? TimeEntryType { get; set; }

    [Column("badge_group")]
    public string? BadgeGroup { get; set; }

    [Column("badge_id")]
    public string? BadgeId { get; set; }

    [Column("login_id")]
    public string? LoginId { get; set; }

    [Column("sft_fl")]
    public bool? SftFl { get; set; }

    [Column("mes_fl")]
    public bool? MesFl { get; set; }

    [Column("clock_fl")]
    public bool? ClockFl { get; set; }

    [Column("plant_id")]
    public string? PlantId { get; set; }

    [Column("empl_source_cd")]
    public string? EmplSourceCd { get; set; }

    [Column("sr_export_dt")]
    public DateTime? SrExportDt { get; set; }

    [Column("hrsmart_export_dt")]
    public DateTime? HrsmartExportDt { get; set; }

    [Column("vet_status_p")]
    public bool? VetStatusP { get; set; }

    [Column("birth_city_name")]
    public string? BirthCityName { get; set; }

    [Column("birth_mail_state_dc")]
    public string? BirthMailStateDc { get; set; }

    [Column("birth_country_cd")]
    public string? BirthCountryCd { get; set; }

    [Column("user_login_id")]
    public string? UserLoginId { get; set; }

    [Column("empl_auth_mthd")]
    public string? EmplAuthMthd { get; set; }

    [Column("ess_user_fl")]
    public bool? EssUserFl { get; set; }

    [Column("last_day_dt")]
    public DateTime? LastDayDt { get; set; }

    [Column("govwiniq_login_id")]
    public string? GovwiniqLoginId { get; set; }

    [Column("hua_id")]
    public string? HuaId { get; set; }

    [Column("hua_actv_map_fl")]
    public bool? HuaActvMapFl { get; set; }

    [Column("vet_status_np")]
    public bool? VetStatusNp { get; set; }

    [Column("vet_status_declined")]
    public bool? VetStatusDeclined { get; set; }

    [Column("vet_status_rs")]
    public bool? VetStatusRs { get; set; }
}

//public class EmployeeMaster
//{
//    public string EmplId { get; set; } = null!; // Required

//    public string? LvPdCd { get; set; }
//    public string? TaxbleEntityId { get; set; }
//    public string? SsnId { get; set; }
//    public DateTime? OrigHireDt { get; set; }
//    public DateTime? AdjHireDt { get; set; }
//    public DateTime? TermDt { get; set; }
//    public string? SEmplStatusCd { get; set; }
//    public string? SpvsrName { get; set; }
//    public string? LastName { get; set; }
//    public string? FirstName { get; set; }
//    public string? MidName { get; set; }
//    public string? PrefName { get; set; }
//    public string? NamePrfxCd { get; set; }
//    public string? NameSfxCd { get; set; }
//    public string? Notes { get; set; }
//    public string? TsPdCd { get; set; }
//    public DateTime? BirthDt { get; set; }
//    public string? CityName { get; set; }
//    public string? CountryCd { get; set; }
//    public string? LastFirstName { get; set; }
//    public string? Ln1Adr { get; set; }
//    public string? Ln2Adr { get; set; }
//    public string? Ln3Adr { get; set; }
//    public string? MailStateDc { get; set; }
//    public string? PostalCd { get; set; }
//    public string? ModifiedBy { get; set; }
//    public DateTime? TimeStamp { get; set; }
//    public string? LocatorCd { get; set; }
//    public string? PrirName { get; set; }
//    public string? CompanyId { get; set; }
//    public DateTime? LastReviewDt { get; set; }
//    public DateTime? NextReviewDt { get; set; }
//    public string? SexCd { get; set; }
//    public string? MaritalCd { get; set; }
//    public bool? EligAutoPayFl { get; set; }
//    public string? EmailId { get; set; }
//    public string? MgrEmplId { get; set; }
//    public string? SRaceCd { get; set; }
//    public string? PrServEmplId { get; set; }
//    public string? CountyName { get; set; }
//    public decimal? TsPdRegHrsNo { get; set; }
//    public decimal? PayPdRegHrsNo { get; set; }
//    public bool? DisabledFl { get; set; }
//    public int? MosReviewNo { get; set; }
//    public string? ContName1 { get; set; }
//    public string? ContName2 { get; set; }
//    public string? ContPhone1 { get; set; }
//    public string? ContPhone2 { get; set; }
//    public string? ContRel1 { get; set; }
//    public string? ContRel2 { get; set; }
//    public bool? UnionEmplFl { get; set; }
//    public string? VisaTypeCd { get; set; }
//    public string? VetStatusS { get; set; }
//    public string? VetStatusV { get; set; }
//    public string? VetStatusO { get; set; }
//    public string? VetStatusR { get; set; }
//    public string? EssPinId { get; set; }
//    public bool? PinUpdatedFl { get; set; }
//    public string? SEssCosCd { get; set; }
//    public string? HomeEmailId { get; set; }
//    public byte[]? Rowversion { get; set; }
//    public DateTime? VetReleaseDt { get; set; }
//    public bool? ContractorFl { get; set; }
//    public bool? BlindFl { get; set; }
//    public DateTime? VisaDt { get; set; }
//    public string? VetStatusD { get; set; }
//    public string? VetStatusA { get; set; }
//    public string? TimeEntryType { get; set; }
//    public string? BadgeGroup { get; set; }
//    public string? BadgeId { get; set; }
//    public string? LoginId { get; set; }
//    public bool? SftFl { get; set; }
//    public bool? MesFl { get; set; }
//    public bool? ClockFl { get; set; }
//    public string? PlantId { get; set; }
//    public string? EmplSourceCd { get; set; }
//    public DateTime? SrExportDt { get; set; }
//    public DateTime? HrsmartExportDt { get; set; }
//    public string? VetStatusP { get; set; }
//    public string? BirthCityName { get; set; }
//    public string? BirthMailStateDc { get; set; }
//    public string? BirthCountryCd { get; set; }
//    public string? UserLoginId { get; set; }
//    public string? EmplAuthMthd { get; set; }
//    public bool? EssUserFl { get; set; }
//    public DateTime? LastDayDt { get; set; }
//    public string? GovwiniqLoginId { get; set; }
//    public string? HuaId { get; set; }
//    public bool? HuaActvMapFl { get; set; }
//    public string? VetStatusNp { get; set; }
//    public string? VetStatusDeclined { get; set; }
//    public string? VetStatusRs { get; set; }
//}

public class PlEmployeee
{
    public int Id { get; set; }

    public string? EmplId { get; set; } = null!;
    public string? OrgId { get; set; }
    public string? FirstName { get; set; }
    public string? LastName { get; set; }

    public string? PlcGlcCode { get; set; }
    public decimal? PerHourRate { get; set; }
    public decimal? Salary { get; set; }
    public decimal? Esc_Percent { get; set; }
    public string? AccId { get; set; }
    public DateOnly? HireDate { get; set; }
    public bool? IsRev { get; set; }
    public bool? IsBrd { get; set; }
    public DateTime? CreatedAt { get; set; } = DateTime.UtcNow;
    public string? Type { get; set; }
    public string? Status { get; set; }

    public int? PlId { get; set; }
    [NotMapped]
    public bool isWarning { get; set; } = false;
    public DateOnly? EffectiveDate { get; set; }
    public virtual ICollection<PlForecast>? PlForecasts { get; set; } = new List<PlForecast>();
    // Navigation properties
    public virtual Organization? Organization { get; set; }
    public virtual PlProjectPlan? PlProjectPlan { get; set; }
}


public class Empl_Master
{
    public string EmplId { get; set; } = null!;

    public string? Status { get; set; }

    public string? FirstName { get; set; }
    public decimal? PerHourRate { get; set; }
    public decimal? Salary { get; set; }
    public DateOnly? EffectiveDate { get; set; }

}
public class Empl_Master_Dto
{
    public string EmplId { get; set; } = null!;

    public string? Status { get; set; }

    public string? FirstName { get; set; }
    public decimal? PerHourRate { get; set; }
    public decimal? Salary { get; set; }
    public DateOnly? EffectiveDate { get; set; }
    public string? Genl_Lab_Cat_CD { get; set; }
    public string? Bill_Lab_Cat_CD { get; set; }

}

public class EmployeeDto
{
    public int EmplId { get; set; }
    public DateTime? Orig_Hire_Dt { get; set; }
    public DateTime? Term_Dt { get; set; }
    public string Last_Name { get; set; }
    public string First_Name { get; set; }
    public string Last_First_Name { get; set; }
}



