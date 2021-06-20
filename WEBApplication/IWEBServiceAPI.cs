using Microsoft.AspNetCore.Mvc;
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

        [Get("/api/CurrentTransformer/{id}")]
        Task<IEnumerable<CurrentTransformer>> GetCurrentTransformer(int id);

        [Get("/api/ElectricityMeter/{id}")]
        Task<IEnumerable<ElectricityMeter>> GetElectricityMeter(int id);

        [Get("/api/PotentialTransformer/{id}")]
        Task<IEnumerable<PotentialTransformer>> GetPotentialTransformer(int id);

        [Post("/api/MeasuringPointCombined")]
        Task<ActionResult<MeasuringPointCombined>> PostMeasuringPointCombined([Microsoft.AspNetCore.Mvc.FromBody] MeasuringPointCombined measuringPointCombined);

        [Get("/api/PointOfUse")]
        Task<IEnumerable<PointOfUse>> GetPointOfUse();

        [Get("/api/ElectricityMeasuringPoint")]
        Task<IEnumerable<ElectricityMeasuringPoint>>GetElectricityMeasuringPoint();
    }
}
