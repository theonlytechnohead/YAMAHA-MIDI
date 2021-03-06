﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Threading;

namespace TouchFaders_MIDI {
	class HandleIO {

		public class FileData {
			public SendsToMix sendsToMix = new SendsToMix();

			public ChannelConfig channelConfig = new ChannelConfig();

			public MixNames mixNames = new MixNames();
			public MixFaders mixFaders = new MixFaders();
		}

		public static FileData LoadAll () {
			FileData data = new FileData();
			try {
				JsonSerializerOptions jsonDeserializerOptions = new JsonSerializerOptions { IgnoreNullValues = true, };

				string sendsToMixFile = File.ReadAllText("config/sendsToMix.txt");
				if (MainWindow.instance.config.sendsToMix_version >= 1) {
					data.sendsToMix.sendLevel = JsonSerializer.Deserialize<List<List<int>>>(sendsToMixFile, jsonDeserializerOptions);
				}

				if (MainWindow.instance.config.channelConfig_version >= 2) {
					string channelConfigFile = File.ReadAllText("config/channelConfig.txt");
					data.channelConfig = JsonSerializer.Deserialize<ChannelConfig>(channelConfigFile, jsonDeserializerOptions);
				}

				if (MainWindow.instance.config.channelConfig_version == 1) {
					MainWindow.instance.config.channelConfig_version = AppConfiguration.appconfig.defaultValues().channelConfig_version;
					File.Delete("config/channelNames.txt");
					File.Delete("config/channelFaders.txt");
				}

				if (MainWindow.instance.config.mixNames_version >= 1) {
					string mixNamesFile = File.ReadAllText("config/mixNames.txt");
					data.mixNames.names = JsonSerializer.Deserialize<List<string>>(mixNamesFile, jsonDeserializerOptions);
				}

				if (MainWindow.instance.config.mixFaders_version >= 1) {
					string mixFadersFile = File.ReadAllText("config/mixFaders.txt");
					data.mixFaders.faders = JsonSerializer.Deserialize<List<int>>(mixFadersFile, jsonDeserializerOptions);
				}
			} catch (FileNotFoundException ex) {
				//await SaveAll(data);
				Dispatcher.CurrentDispatcher.Invoke(() => System.Windows.MessageBox.Show(ex.Message));
			} catch (Exception ex) {
				Dispatcher.CurrentDispatcher.Invoke(() => System.Windows.MessageBox.Show(ex.StackTrace, ex.Message));
			}
			return data;
		}

		public static async Task SaveAll (FileData data) {
			JsonSerializerOptions serializerOptions = new JsonSerializerOptions { WriteIndented = true, IgnoreNullValues = true, };
			_ = Directory.CreateDirectory("config");
			if (data.sendsToMix != null) {
				using (FileStream fs = File.Create("config/sendsToMix.txt")) {
					await JsonSerializer.SerializeAsync(fs, data.sendsToMix.sendLevel, serializerOptions);
				}
			}
			if (data.channelConfig != null) {
				using (FileStream fs = File.Create("config/channelConfig.txt")) {
					await JsonSerializer.SerializeAsync(fs, data.channelConfig, serializerOptions);
				}
			}
		}
	}
}