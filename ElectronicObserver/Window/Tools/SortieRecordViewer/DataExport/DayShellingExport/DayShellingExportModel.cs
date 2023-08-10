﻿using System;

namespace ElectronicObserver.Window.Tools.SortieRecordViewer.DataExport.DayShellingExport;

// all required
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
public record DayShellingExportModel
{
	public int No { get; init; }
	public DateTime Date { get; init; }
	public string World { get; init; }
	public string Square { get; init; }
	public string Sortie { get; init; }
	public string? Rank { get; init; }
	public string? EnemyFleet { get; init; }
	public int? AdmiralLevel { get; init; }
	public string PlayerFormation { get; init; }
	public string EnemyFormation { get; init; }
	public string PlayerSearch { get; init; }
	public string EnemySearch { get; init; }
	public string AirState { get; init; }
	public string Engagement { get; init; }
	public string? PlayerContact { get; init; }
	public string? EnemyContact { get; init; }
	public string? PlayerFlare { get; init; }
	public string? EnemyFlare { get; init; }
	public string BattleType { get; init; }
	public string? ShipName1 { get; init; }
	public string? ShipName2 { get; init; }
	public string? ShipName3 { get; init; }
	public string? ShipName4 { get; init; }
	public string? ShipName5 { get; init; }
	public string? ShipName6 { get; init; }
	public string PlayerFleetType { get; init; }
	public string BattlePhase { get; init; }
	public string AttackerSide { get; init; }
	public int AttackType { get; init; }
	public int AttackIndex { get; init; }
	public string? DisplayedEquipment1 { get; init; }
	public string? DisplayedEquipment2 { get; init; }
	public string? DisplayedEquipment3 { get; init; }
	public int HitType { get; init; }
	public int Damage { get; init; }
	public int Protected { get; init; }
	public int AttackerIndex { get; init; }
	public int AttackerId { get; init; }
	public string AttackerName { get; init; }
	public string AttackerShipType { get; init; }
	public int? AttackerCondition { get; init; }
	public int AttackerHpCurrent { get; init; }
	public int AttackerHpMax { get; init; }
	public string AttackerDamageState { get; init; }
	public int? AttackerFuelCurrent { get; init; }
	public int AttackerFuelMax { get; init; }
	public int? AttackerAmmoCurrent { get; init; }
	public int AttackerAmmoMax { get; init; }
	public int AttackerLevel { get; init; }
	public string AttackerSpeed { get; init; }
	public int AttackerFirepower { get; init; }
	public int AttackerTorpedo { get; init; }
	public int AttackerAntiAir { get; init; }
	public int AttackerArmor { get; init; }
	public int AttackerEvasion { get; init; }
	public int AttackerAntiSubmarine { get; init; }
	public int AttackerSearch { get; init; }
	public int AttackerLuck { get; init; }
	public string AttackerRange { get; init; }
	public string? AttackerEquipment1Name { get; init; }
	public int? AttackerEquipment1Level { get; init; }
	public int? AttackerEquipment1AircraftLevel { get; init; }
	public int? AttackerEquipment1Aircraft { get; init; }
	public string? AttackerEquipment2Name { get; init; }
	public int? AttackerEquipment2Level { get; init; }
	public int? AttackerEquipment2AircraftLevel { get; init; }
	public int? AttackerEquipment2Aircraft { get; init; }
	public string? AttackerEquipment3Name { get; init; }
	public int? AttackerEquipment3Level { get; init; }
	public int? AttackerEquipment3AircraftLevel { get; init; }
	public int? AttackerEquipment3Aircraft { get; init; }
	public string? AttackerEquipment4Name { get; init; }
	public int? AttackerEquipment4Level { get; init; }
	public int? AttackerEquipment4AircraftLevel { get; init; }
	public int? AttackerEquipment4Aircraft { get; init; }
	public string? AttackerEquipment5Name { get; init; }
	public int? AttackerEquipment5Level { get; init; }
	public int? AttackerEquipment5AircraftLevel { get; init; }
	public int? AttackerEquipment5Aircraft { get; init; }
	public string? AttackerEquipment6Name { get; init; }
	public int? AttackerEquipment6Level { get; init; }
	public int? AttackerEquipment6AircraftLevel { get; init; }
	public int? AttackerEquipment6Aircraft { get; init; }
	public int DefenderIndex { get; init; }
	public int DefenderId { get; init; }
	public string DefenderName { get; init; }
	public string DefenderShipType { get; init; }
	public int? DefenderCondition { get; init; }
	public int DefenderHpCurrent { get; init; }
	public int DefenderHpMax { get; init; }
	public string DefenderDamageState { get; init; }
	public int? DefenderFuelCurrent { get; init; }
	public int DefenderFuelMax { get; init; }
	public int? DefenderAmmoCurrent { get; init; }
	public int DefenderAmmoMax { get; init; }
	public int DefenderLevel { get; init; }
	public string DefenderSpeed { get; init; }
	public int DefenderFirepower { get; init; }
	public int DefenderTorpedo { get; init; }
	public int DefenderAntiAir { get; init; }
	public int DefenderArmor { get; init; }
	public int DefenderEvasion { get; init; }
	public int DefenderAntiSubmarine { get; init; }
	public int DefenderSearch { get; init; }
	public int DefenderLuck { get; init; }
	public string DefenderRange { get; init; }
	public string? DefenderEquipment1Name { get; init; }
	public int? DefenderEquipment1Level { get; init; }
	public int? DefenderEquipment1AircraftLevel { get; init; }
	public int? DefenderEquipment1Aircraft { get; init; }
	public string? DefenderEquipment2Name { get; init; }
	public int? DefenderEquipment2Level { get; init; }
	public int? DefenderEquipment2AircraftLevel { get; init; }
	public int? DefenderEquipment2Aircraft { get; init; }
	public string? DefenderEquipment3Name { get; init; }
	public int? DefenderEquipment3Level { get; init; }
	public int? DefenderEquipment3AircraftLevel { get; init; }
	public int? DefenderEquipment3Aircraft { get; init; }
	public string? DefenderEquipment4Name { get; init; }
	public int? DefenderEquipment4Level { get; init; }
	public int? DefenderEquipment4AircraftLevel { get; init; }
	public int? DefenderEquipment4Aircraft { get; init; }
	public string? DefenderEquipment5Name { get; init; }
	public int? DefenderEquipment5Level { get; init; }
	public int? DefenderEquipment5AircraftLevel { get; init; }
	public int? DefenderEquipment5Aircraft { get; init; }
	public string? DefenderEquipment6Name { get; init; }
	public int? DefenderEquipment6Level { get; init; }
	public int? DefenderEquipment6AircraftLevel { get; init; }
	public int? DefenderEquipment6Aircraft { get; init; }
	public string FleetType { get; init; }
	public string EnemyFleetType { get; init; }
}
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
