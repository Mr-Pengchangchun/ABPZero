﻿using Abp.AspNetCore.Mvc.ViewComponents;

namespace ABPCore.PhoneBook.Web.Views
{
    public abstract class PhoneBookViewComponent : AbpViewComponent
    {
        protected PhoneBookViewComponent()
        {
            LocalizationSourceName = PhoneBookConsts.LocalizationSourceName;
        }
    }
}
