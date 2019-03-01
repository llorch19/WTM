﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using WalkingTec.Mvvm.Core;
using WalkingTec.Mvvm.Core.Extensions;
using WalkingTec.Mvvm.ApiDemo;


namespace WalkingTec.Mvvm.ApiDemo.ViewModels.TestModelVMs
{
    public class TestModelTemplateVM : BaseTemplateVM
    {
        public ExcelPropety Teset_Excel = ExcelPropety.CreateProperty<TestModel>(x => x.Teset);

	    protected override void InitVM()
        {
        }

    }

    public class TestModelImportVM : BaseImportVM<TestModelTemplateVM, TestModel>
    {

    }

}
