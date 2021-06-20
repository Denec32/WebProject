﻿using Microsoft.AspNetCore.Mvc;
using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Http;
using WEBService.Models;

namespace WEBApplication
{
    public interface IWEBServiceAPI
    {

        [Get("/api/CurrentTransformerGet/{id}")]
        Task<IEnumerable<CurrentTransformer>> GetCurrentTransformer(int id);

        [Get("/api/ElectricityMeterGet/{id}")]
        Task<IEnumerable<ElectricityMeter>> GetElectricityMeter(int id);

        [Get("/api/PotentialTransformerGet/{id}")]
        Task<IEnumerable<PotentialTransformer>> GetPotentialTransformer(int id);

        [Post("/api/MeasurementPointInfo")]
        Task<ActionResult<MeasuringPointCombined>> PostMeasuringPointCombined([Microsoft.AspNetCore.Mvc.FromBody] MeasuringPointCombined measuringPointCombined);

        [Get("/api/PointOfUseGet")]
        Task<IEnumerable<PointOfUse>> GetPointOfUse();

        [Get("/api/ElectricityMeasuringPointGet")]
        Task<IEnumerable<ElectricityMeasuringPoint>>GetElectricityMeasuringPoint();
    }
}
