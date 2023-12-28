﻿using System.Text.Json.Serialization;

namespace ElectronicObserverTypes.Serialization.FleetAnalysis;

public class FleetAnalysisEquipment
{
	[JsonPropertyName("api_slotitem_id")] public required EquipmentId Id { get; set; }
	[JsonPropertyName("api_level")] public required int Level { get; set; }
}
