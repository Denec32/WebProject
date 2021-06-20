function FillForm() {
    document.getElementById("ElectricityMeasuringPoint.Name").value = "Point 1";

    document.getElementById("ElectricityMeter.Number").value = "1A";
    document.getElementById("ElectricityMeter.MeterType").value = "Type-01";
    document.getElementById("ElectricityMeter.CheckDate").value = "2021-06-18T14:47";

    document.getElementById("CurrentTransformer.Number").value = "1B";
    document.getElementById("CurrentTransformer.TransformerType").value = "Type-02";
    document.getElementById("CurrentTransformer.TransformationRatio").value = 1.8;
    document.getElementById("CurrentTransformer.CheckDate").value = "2021-06-18T14:47";

    document.getElementById("PotentialTransformer.Number").value = "1C";
    document.getElementById("PotentialTransformer.TransformerType").value = "Type-03";
    document.getElementById("PotentialTransformer.TransformationRatio").value = 1.6;
    document.getElementById("PotentialTransformer.CheckDate").value = "2021-06-18T14:47";
}