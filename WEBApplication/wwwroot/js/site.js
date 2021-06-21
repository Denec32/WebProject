function FillForm() {
    document.getElementById("ElectricityMeasuringPoint_Name").value = "Point 1";

    document.getElementById("ElectricityMeter_Number").value = "1A";
    document.getElementById("ElectricityMeter_MeterType").value = "Type-01";
    document.getElementById("ElectricityMeter_CheckDate").value = "2021-06-18T14:47";

    document.getElementById("CurrentTransformer_Number").value = "1B";
    document.getElementById("CurrentTransformer_TransformerType").value = "Type-02";
    document.getElementById("CurrentTransformer_TransformationRatio").value = "1,8";
    document.getElementById("CurrentTransformer_CheckDate").value = "2021-06-18T14:47";

    document.getElementById("PotentialTransformer_Number").value = "1C";
    document.getElementById("PotentialTransformer_TransformerType").value = "Type-03";
    document.getElementById("PotentialTransformer_TransformationRatio").value = "1,6";
    document.getElementById("PotentialTransformer_CheckDate").value = "2021-06-18T14:47";
}