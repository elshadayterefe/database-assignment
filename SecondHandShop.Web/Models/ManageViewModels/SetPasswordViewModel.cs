﻿namespace SecondHandShop.Web.Models.ManageViewModels
{
    using SecondHandShop.Data;
    using System.ComponentModel.DataAnnotations;

    public class SetPasswordViewModel
    {
        [Required]
        [StringLength(DataConstants.NewPasswordMaxLenth, ErrorMessage = DataConstants.ErrorMessageTwoFactorCode, MinimumLength = DataConstants.MinLenthOfStuffs)]
        [DataType(DataType.Password)]
        [Display(Name = DataConstants.DisplayNewPassword)]
        public string NewPassword { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = DataConstants.DisplayConfirmNewPassword)]
        [Compare(DataConstants.NewPassword, ErrorMessage = DataConstants.ErrorMessageConfirmNewPassword)]
        public string ConfirmPassword { get; set; }

        public string StatusMessage { get; set; }
    }
}