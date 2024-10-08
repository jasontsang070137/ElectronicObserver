﻿using System;
using ElectronicObserver.Observer;

namespace ElectronicObserver.Utility.ElectronicObserverApi.DataIssueLogs;

public class DataAndTranslationIssueReporter
{
	private WrongUpgradesIssueReporter WrongUpgradesIssueReporter { get; }
	private FitBonusIssueReporter FitBonusIssueReporter { get; }
	private SoftwareIssueReporter SoftwareIssueReporter { get; }

	public DataAndTranslationIssueReporter(WrongUpgradesIssueReporter wrongUpgrades, FitBonusIssueReporter fitBonuses, SoftwareIssueReporter softwareIssues)
	{
		WrongUpgradesIssueReporter = wrongUpgrades;
		FitBonusIssueReporter = fitBonuses;
		SoftwareIssueReporter = softwareIssues;

		SubscribeToApi();
	}

	private void SubscribeToApi()
	{
		APIObserver api = APIObserver.Instance;

		api.ApiReqKousyou_RemodelSlotList.ResponseReceived += WrongUpgradesIssueReporter.ProcessUpgradeList;

		// fixme : currently report false positive (and issue on remodel even tho there's code to prevent that)
		//api.ApiGetMember_Ship3.ResponseReceived += FitBonusIssueReporter.ProcessShipDataChanged;

		AppDomain.CurrentDomain.UnhandledException += SoftwareIssueReporter.ProcessException;
	}
}
