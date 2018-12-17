﻿using System.Linq;
using System.Reflection;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ApplicationModels;

namespace ProblemDetailsDemo.Api.MvcCustomizations
{
    public abstract class ApiConvention : IControllerModelConvention
    {
        void IControllerModelConvention.Apply(ControllerModel controller)
        {
            if (IsApiController(controller))
            {
                ApplyControllerConvention(controller);
            }
        }

        protected virtual bool IsApiController(ControllerModel controller)
        {
            if (controller.Attributes.OfType<ApiControllerAttribute>().Any())
            {
                return true;
            }

            return controller.ControllerType.Assembly.GetCustomAttributes().OfType<ApiControllerAttribute>().Any();
        }

        protected abstract void ApplyControllerConvention(ControllerModel controller);
    }
}