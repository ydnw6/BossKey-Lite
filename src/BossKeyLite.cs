using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Microsoft.Win32;

[assembly: CompilationRelaxations(8)]
[assembly: RuntimeCompatibility(WrapNonExceptionThrows = true)]
[assembly: Debuggable(DebuggableAttribute.DebuggingModes.IgnoreSymbolStoreSequencePoints)]
[assembly: TargetFramework(".NETFramework,Version=v4.8", FrameworkDisplayName = ".NET Framework 4.8")]
[assembly: AssemblyCompany("Dingjianbin")]
[assembly: AssemblyConfiguration("Release")]
[assembly: AssemblyCopyright("Copyright (c) 2026 Dingjianbin")]
[assembly: AssemblyDescription("老板键一键隐藏指定程序的窗口与托盘图标，任务栏保持可见")]
[assembly: AssemblyFileVersion("1.3.15.0")]
[assembly: AssemblyInformationalVersion("1.3.15")]
[assembly: AssemblyProduct("一键隐身·轻享版")]
[assembly: AssemblyTitle("一键隐身·轻享版")]
[assembly: NeutralResourcesLanguage("zh-CN")]
[assembly: AssemblyVersion("1.3.15.0")]
namespace MoyuBossKey
{

// “关于作者”对话框，界面控件由代码动态创建。
internal sealed class AboutAuthorDialog : Form
{
	private const string Author = "联系作者";

	private const string ContactCaption = "Telegram";

	private const string ContactValue = "@ydnw6";

	private const string ContactValueQq = "959649446";

	private const string Footer = "通过 Telegram 或 QQ 联系作者";

	public AboutAuthorDialog()
	{
		BuildUi();
	}

	private void BuildUi()
	{
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Expected Obj, but got Unknown
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Expected Obj, but got Unknown
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Expected Obj, but got Unknown
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d4: Expected Obj, but got Unknown
		//IL_0148: Unknown result type (might be due to invalid IL or missing references)
		//IL_014e: Expected Obj, but got Unknown
		//IL_0196: Unknown result type (might be due to invalid IL or missing references)
		//IL_019c: Expected Obj, but got Unknown
		((Control)this).Text = "关于作者";
		((Control)this).Font = new Font("Microsoft YaHei UI", 9f);
		((Form)this).FormBorderStyle = (FormBorderStyle)3;
		((Form)this).MaximizeBox = false;
		((Form)this).MinimizeBox = false;
		((Form)this).ShowInTaskbar = false;
		((Form)this).StartPosition = (FormStartPosition)4;
		((Form)this).ClientSize = new Size(340, 236);
		((Control)this).BackColor = Color.White;
		((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
		Label val = new Label();
		((Control)val).Text = Author;
		((Control)val).Font = new Font("Microsoft YaHei UI", 14f, (FontStyle)1);
		((Control)val).ForeColor = Color.FromArgb(204, 58, 46);
		val.TextAlign = (ContentAlignment)32;
		((Control)val).Bounds = new Rectangle(0, 22, 340, 34);
		((Control)this).Controls.Add((Control)(object)val);
		Panel val2 = new Panel();
		((Control)val2).Bounds = new Rectangle(20, 70, 300, 78);
		((Control)val2).BackColor = Color.FromArgb(240, 246, 253);
		((Control)this).Controls.Add((Control)(object)val2);
		((Control)val2).Controls.Add(MakeRow(ContactCaption, ContactValue, 26));
		((Control)val2).Controls.Add(MakeRow("QQ", ContactValueQq, 52));
		Label val3 = new Label();
		((Control)val3).Text = Footer;
		((Control)val3).ForeColor = Color.FromArgb(120, 120, 120);
		val3.TextAlign = (ContentAlignment)32;
		((Control)val3).Bounds = new Rectangle(0, 158, 340, 20);
		((Control)this).Controls.Add((Control)(object)val3);
		Button val4 = new Button();
		((Control)val4).Text = "确定";
		((Control)val4).Bounds = new Rectangle(190, 190, 88, 28);
		((ButtonBase)val4).FlatStyle = (FlatStyle)0;
		((ButtonBase)val4).FlatAppearance.BorderSize = 1;
		((ButtonBase)val4).FlatAppearance.BorderColor = Color.FromArgb(204, 58, 46);
		((ButtonBase)val4).UseVisualStyleBackColor = false;
		((Control)val4).BackColor = Color.FromArgb(204, 58, 46);
		((Control)val4).ForeColor = Color.White;
		((Control)val4).Cursor = Cursors.Hand;
		((Control)val4).Click += delegate
		{
			((Form)this).Close();
		};
		((Control)this).Controls.Add((Control)(object)val4);
((Form)this).AcceptButton = (IButtonControl)(object)val4;
		((Form)this).CancelButton = (IButtonControl)(object)val4;
	}

	private static Control MakeRow(string caption, string value, int top)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Expected Obj, but got Unknown
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Expected Obj, but got Unknown
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Expected Obj, but got Unknown
		//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Expected Obj, but got Unknown
		Panel val = new Panel
		{
			Bounds = new Rectangle(0, top, 300, 26),
			BackColor = Color.Transparent
		};
		Label val2 = new Label();
		((Control)val2).Text = caption;
		((Control)val2).ForeColor = Color.FromArgb(120, 120, 120);
		val2.TextAlign = (ContentAlignment)16;
		((Control)val2).Bounds = new Rectangle(18, 0, 96, 26);
		((Control)val).Controls.Add((Control)(object)val2);
		LinkLabel val3 = new LinkLabel();
		val3.LinkClicked += delegate
		{
			if (caption == "QQ")
			{
				try { Clipboard.SetText(value); } catch (Exception) { }
				MessageBox.Show("QQ 号已复制到剪贴板：" + value, "联系作者", MessageBoxButtons.OK, MessageBoxIcon.Information);
				return;
			}
			try
			{
				Process.Start(new ProcessStartInfo("https://t.me/ydnw6") { UseShellExecute = true });
			}
			catch (Exception)
			{
				MessageBox.Show("无法打开浏览器，请访问：https://t.me/ydnw6", "联系作者", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
		};
		((Control)val3).Text = value;
		((Control)val3).Font = new Font("Microsoft YaHei UI", 9.5f, (FontStyle)1);
		((Control)val3).ForeColor = Color.FromArgb(40, 40, 40);
		val3.TextAlign = (ContentAlignment)16;
		((Control)val3).Bounds = new Rectangle(120, 0, 162, 26);
		((Control)val).Controls.Add((Control)(object)val3);
		return (Control)val;
	}
}
internal sealed class AppInfo : IDisposable
{
	// 程序选择器中显示的一个应用及其窗口信息。
	public string Exe = string.Empty;

	public string ExePath = string.Empty;

	public string Title = string.Empty;

	public int WindowCount;

	public bool Running = true;

	private Icon _icon;

	private bool _iconOwned;

	public string DisplayName
	{
		get
		{
			string text = ((Title == null) ? string.Empty : Title.Trim());
			if (text.Length > 42)
			{
				text = text.Substring(0, 42) + "…";
			}
			if (text.Length > 0)
			{
				return text;
			}
			if (!Exe.EndsWith(".exe", StringComparison.OrdinalIgnoreCase))
			{
				return Exe;
			}
			return Exe.Substring(0, Exe.Length - 4);
		}
	}

	public Icon Icon
	{
		get
		{
			if (_icon != null)
			{
				return _icon;
			}
			try
			{
				if (ExePath.Length > 0 && File.Exists(ExePath))
				{
					_icon = Icon.ExtractAssociatedIcon(ExePath);
					_iconOwned = _icon != null;
				}
			}
			catch (Exception)
			{
			}
			if (_icon == null)
			{
				_icon = SystemIcons.Application;
			}
			return _icon;
		}
	}

	public void Dispose()
	{
		if (_icon != null && _iconOwned)
		{
			_icon.Dispose();
		}
		_icon = null;
		_iconOwned = false;
	}
}
internal static class AppCatalog
{
	// 通过顶层窗口反查当前正在运行的应用。
	// pid→exe 名称短期缓存：Process.GetProcessById 开销大，而防隐藏/防录屏的
	// EnumWindows 循环每秒会反复查同一批 pid，缓存可大幅降低 CPU 占用，消除卡顿。
	private static readonly Dictionary<uint, string> _exeNameCache = new Dictionary<uint, string>();
	private static readonly Dictionary<uint, int> _exeNameStamp = new Dictionary<uint, int>();
	private static readonly object _exeNameSync = new object();

	public static string ProcessExeOf(uint pid)
	{
		int now = Environment.TickCount;
		lock (_exeNameSync)
		{
			int stamp;
			string cached;
			if (_exeNameStamp.TryGetValue(pid, out stamp) && (uint)(now - stamp) < 1500u
				&& _exeNameCache.TryGetValue(pid, out cached))
			{
				return cached;
			}
		}
		string result;
		try
		{
			using Process process = Process.GetProcessById((int)pid);
			result = (process.ProcessName + ".exe").ToLowerInvariant();
		}
		catch (Exception)
		{
			result = string.Empty;
		}
		lock (_exeNameSync)
		{
			if (_exeNameCache.Count > 512) { _exeNameCache.Clear(); _exeNameStamp.Clear(); }
			_exeNameCache[pid] = result;
			_exeNameStamp[pid] = now;
		}
		return result;
	}

	public static string ProcessPathOf(uint pid)
	{
		try
		{
			using Process process = Process.GetProcessById((int)pid);
			return process.MainModule.FileName;
		}
		catch (Exception)
		{
			return string.Empty;
		}
	}

	public static List<AppInfo> EnumerateRunning(IntPtr selfHandle, uint selfPid)
	{
		// 每个进程只读取一次路径，避免枚举多个窗口时重复访问进程。
		Dictionary<string, AppInfo> map = new Dictionary<string, AppInfo>(StringComparer.OrdinalIgnoreCase);
		Dictionary<uint, string[]> pathCache = new Dictionary<uint, string[]>();
		Native.EnumWindows((IntPtr hWnd, IntPtr lParam) =>
		{
			if (!WindowHider.IsHideCandidate(hWnd, selfHandle, selfPid, out var pid, out var _))
			{
				return true;
			}
			if (!pathCache.TryGetValue(pid, out var value))
			{
				value = new string[2]
				{
					ProcessExeOf(pid),
					ProcessPathOf(pid)
				};
				pathCache[pid] = value;
			}
			string text = value[0];
			if (text.Length == 0)
			{
				return true;
			}
			if (!map.TryGetValue(text, out var value2))
			{
				value2 = new AppInfo
				{
					Exe = text,
					ExePath = value[1],
					Title = Native.TextOf(hWnd),
					Running = true
				};
				map[text] = value2;
			}
			if (value2.Title.Trim().Length == 0)
			{
				value2.Title = Native.TextOf(hWnd);
			}
			value2.WindowCount++;
			return true;
		}, IntPtr.Zero);
		List<AppInfo> list = new List<AppInfo>(map.Values);
		list.Sort((AppInfo a, AppInfo b) => string.Compare(a.DisplayName, b.DisplayName, StringComparison.CurrentCulture));
		return list;
	}
}
internal sealed class AppConfig
{
	// 用户配置：全局热键、开机启动和需要隐藏的进程名。
	public Keys HotKey = (Keys)393297;

	public bool AutoStart;

	// 防录屏/防截屏：轻享版不含此功能，保留字段仅为兼容旧配置（始终关闭）。
	public bool AntiCapture = false;

	// 隐身时暂停正在播放的音/视频（发送媒体暂停键），恢复时继续。默认开启。
	public bool PauseMedia = true;

	// 是否已经展示过「首次运行·永久免费」提示（展示一次后置 1，后续不再弹）。
	public bool FreeNoticeShown;

	public readonly List<string> HideProcesses = new List<string>();

	private const string RunKeyPath = "Software\\Microsoft\\Windows\\CurrentVersion\\Run";

	private const string RunValueName = "MoyuBossKeyLite";

	public bool HasProcessFilter => HideProcesses.Count > 0;

	public static string DataDir
	{
		get
		{
			string text = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "MoyuBossKeyLite");
			try
			{
				if (!Directory.Exists(text))
				{
					Directory.CreateDirectory(text);
				}
			}
			catch (Exception)
			{
				text = AppDomain.CurrentDomain.BaseDirectory;
			}
			return text;
		}
	}

	private static string ConfigPath => Path.Combine(DataDir, "config.ini");

	public static string NormalizeExe(string raw)
	{
		if (raw == null)
		{
			return string.Empty;
		}
		string text = raw.Trim().Trim(new char[1] { '"' }).Trim()
			.ToLowerInvariant();
		int num = text.LastIndexOf('\\');
		if (num >= 0)
		{
			text = text.Substring(num + 1);
		}
		if (text.Length == 0)
		{
			return string.Empty;
		}
		if (!text.EndsWith(".exe", StringComparison.Ordinal))
		{
			text += ".exe";
		}
		return text;
	}

	public static AppConfig Load()
	{
		// 配置文件采用简单的 key=value 格式，未知项目会被忽略。
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		AppConfig appConfig = new AppConfig();
		try
		{
			if (!File.Exists(ConfigPath))
			{
				return appConfig;
			}
			string[] array = File.ReadAllLines(ConfigPath, Encoding.UTF8);
			for (int i = 0; i < array.Length; i++)
			{
				string text = array[i].Trim();
				if (text.Length == 0 || text.StartsWith("#", StringComparison.Ordinal))
				{
					continue;
				}
				int num = text.IndexOf('=');
				if (num <= 0)
				{
					continue;
				}
				string text2 = text.Substring(0, num).Trim();
				string text3 = text.Substring(num + 1).Trim();
				switch (text2)
				{
				case "HotKey":
				{
					if (int.TryParse(text3, NumberStyles.Integer, CultureInfo.InvariantCulture, out var result) && result != 0)
					{
						appConfig.HotKey = (Keys)result;
					}
					break;
				}
				case "HideProcess":
				{
					string text4 = NormalizeExe(text3);
					if (text4.Length > 0 && !appConfig.HideProcesses.Contains(text4))
					{
						appConfig.HideProcesses.Add(text4);
					}
					break;
				}
				case "AutoStart":
					appConfig.AutoStart = text3 == "1";
					break;
				case "AntiCapture":
					appConfig.AntiCapture = false; // 轻享版不含防录屏，忽略旧配置
					break;
				case "PauseMedia":
					appConfig.PauseMedia = text3 != "0";
					break;
				case "FreeNoticeShown":
					appConfig.FreeNoticeShown = text3 == "1";
					break;
				}
			}
		}
		catch (Exception)
		{
		}
		return appConfig;
	}

	public void Save()
	{
		// 将当前设置写回用户目录下的配置文件。
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Expected I4, but got Unknown
		try
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.AppendLine("# 一键隐身·轻享版 配置文件");
			stringBuilder.AppendLine("HotKey=" + ((int)HotKey).ToString(CultureInfo.InvariantCulture));
			foreach (string hideProcess in HideProcesses)
			{
				stringBuilder.AppendLine("HideProcess=" + hideProcess);
			}
			stringBuilder.AppendLine("AutoStart=" + (AutoStart ? "1" : "0"));
			stringBuilder.AppendLine("AntiCapture=" + (AntiCapture ? "1" : "0"));
			stringBuilder.AppendLine("PauseMedia=" + (PauseMedia ? "1" : "0"));
			stringBuilder.AppendLine("FreeNoticeShown=" + (FreeNoticeShown ? "1" : "0"));
			File.WriteAllText(ConfigPath, stringBuilder.ToString(), new UTF8Encoding(encoderShouldEmitUTF8Identifier: false));
		}
		catch (Exception)
		{
		}
	}

	public void ApplyAutoStart()
	{
		// 使用当前用户的 Run 注册表项控制开机启动。
		try
		{
			using RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true);
			if (registryKey != null)
			{
				if (AutoStart)
				{
					string executablePath = Application.ExecutablePath;
					registryKey.SetValue("MoyuBossKeyLite", "\"" + executablePath + "\"", RegistryValueKind.String);
				}
				else if (registryKey.GetValue("MoyuBossKeyLite") != null)
				{
					registryKey.DeleteValue("MoyuBossKeyLite", throwOnMissingValue: false);
				}
			}
		}
		catch (Exception)
		{
		}
	}

	public AppConfig()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
	}
}
internal sealed class HiddenSnapshot
{
	// 进程异常退出后用于恢复窗口和托盘图标的持久化状态。
	public readonly List<IntPtr> Windows = new List<IntPtr>();

	public readonly List<string> TrayExes = new List<string>();
}
internal static class HiddenStateStore
{
	// 隐藏操作期间保存的状态文件，避免应用崩溃后窗口永久不可见。
	private static string FilePath => Path.Combine(AppConfig.DataDir, "hidden.bin");

	public static void Save(List<IntPtr> handles, ICollection<string> trayExes)
	{
		try
		{
			int num = handles?.Count ?? 0;
			int num2 = trayExes?.Count ?? 0;
			if (num == 0 && num2 == 0)
			{
				Log.Write("HiddenStateStore.Save -> 无内容，清空存档");
				Clear();
				return;
			}
			Log.Write("HiddenStateStore.Save windows=" + num + " trayExes=" + num2);
			using FileStream output = new FileStream(FilePath, FileMode.Create, FileAccess.Write, FileShare.None);
			using BinaryWriter binaryWriter = new BinaryWriter(output);
			binaryWriter.Write(2);
			binaryWriter.Write(num);
			if (handles != null)
			{
				foreach (IntPtr handle in handles)
				{
					binaryWriter.Write(handle.ToInt64());
				}
			}
			binaryWriter.Write(num2);
			if (trayExes == null)
			{
				return;
			}
			foreach (string trayEx in trayExes)
			{
				binaryWriter.Write(trayEx ?? string.Empty);
			}
		}
		catch (Exception)
		{
		}
	}

	public static HiddenSnapshot Load()
	{
		HiddenSnapshot hiddenSnapshot = new HiddenSnapshot();
		try
		{
			if (!File.Exists(FilePath))
			{
				return hiddenSnapshot;
			}
			using FileStream input = new FileStream(FilePath, FileMode.Open, FileAccess.Read, FileShare.Read);
			using BinaryReader binaryReader = new BinaryReader(input);
			int num = binaryReader.ReadInt32();
			if (num != 1 && num != 2)
			{
				return hiddenSnapshot;
			}
			int num2 = binaryReader.ReadInt32();
			if (num2 < 0 || num2 > 100000)
			{
				return hiddenSnapshot;
			}
			for (int i = 0; i < num2; i++)
			{
				long num3 = binaryReader.ReadInt64();
				if (num3 != 0L)
				{
					hiddenSnapshot.Windows.Add(new IntPtr(num3));
				}
			}
			if (num >= 2)
			{
				int num4 = binaryReader.ReadInt32();
				if (num4 < 0 || num4 > 10000)
				{
					return hiddenSnapshot;
				}
				for (int j = 0; j < num4; j++)
				{
					string text = binaryReader.ReadString();
					if (!string.IsNullOrEmpty(text))
					{
						hiddenSnapshot.TrayExes.Add(text);
					}
				}
			}
		}
		catch (Exception ex)
		{
			Log.Error("HiddenStateStore.Load", ex);
			return new HiddenSnapshot();
		}
		return hiddenSnapshot;
	}

	public static void Clear()
	{
		try
		{
			if (File.Exists(FilePath))
			{
				File.Delete(FilePath);
			}
		}
		catch (Exception)
		{
		}
	}

	public static int RecoverOrphaned()
	{
		// 启动时恢复上一次未正常清理的隐藏对象。
		HiddenSnapshot hiddenSnapshot = Load();
		Log.Write("RecoverOrphaned: windows=" + hiddenSnapshot.Windows.Count + " trayExes=" + hiddenSnapshot.TrayExes.Count);
		if (hiddenSnapshot.Windows.Count == 0 && hiddenSnapshot.TrayExes.Count == 0)
		{
			Clear();
			return 0;
		}
		int num = 0;
		foreach (IntPtr window in hiddenSnapshot.Windows)
		{
			if (Native.IsWindow(window) && !Native.IsWindowVisible(window))
			{
				Native.ShowWindow(window, 4);
				if (Native.IsWindowVisible(window))
				{
					num++;
				}
			}
		}
		if (hiddenSnapshot.TrayExes.Count > 0)
		{
			try
			{
				TrayIconHider.Restore(hiddenSnapshot.TrayExes);
			}
			catch (Exception)
			{
			}
		}
		IntPtr intPtr = Native.FindWindow("Shell_TrayWnd", null);
		if (intPtr != IntPtr.Zero && !Native.IsWindowVisible(intPtr))
		{
			Native.ShowWindow(intPtr, 5);
		}
		Native.EnumWindows((IntPtr hWnd, IntPtr lParam) =>
		{
			if (string.Equals(Native.ClassOf(hWnd), "Shell_SecondaryTrayWnd", StringComparison.Ordinal) && !Native.IsWindowVisible(hWnd))
			{
				Native.ShowWindow(hWnd, 5);
			}
			return true;
		}, IntPtr.Zero);
		EnsureDesktopIconsVisible();
		Log.Write("RecoverOrphaned done, restored windows=" + num);
		Clear();
		return num;
	}

	private static void EnsureDesktopIconsVisible()
	{
		RevealDefViewUnder(Native.FindWindow("Progman", null));
		Native.EnumWindows((IntPtr hWnd, IntPtr lParam) =>
		{
			if (string.Equals(Native.ClassOf(hWnd), "WorkerW", StringComparison.Ordinal))
			{
				RevealDefViewUnder(hWnd);
			}
			return true;
		}, IntPtr.Zero);
	}

	private static void RevealDefViewUnder(IntPtr root)
	{
		if (root == IntPtr.Zero)
		{
			return;
		}
		Native.EnumChildWindows(root, (IntPtr hWnd, IntPtr lParam) =>
		{
			if (string.Equals(Native.ClassOf(hWnd), "SHELLDLL_DefView", StringComparison.Ordinal) && !Native.IsWindowVisible(hWnd))
			{
				Native.ShowWindow(hWnd, 4);
			}
			return true;
		}, IntPtr.Zero);
	}
}
internal sealed class ElevatedPromptDialog : Form
{
	// 当目标程序以管理员权限运行时，提示用户是否以管理员身份重启。
	public ElevatedPromptDialog(IList<string> elevatedExes)
	{
		BuildUi(elevatedExes);
	}

	private void BuildUi(IList<string> elevatedExes)
	{
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Expected Obj, but got Unknown
		//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d0: Expected Obj, but got Unknown
		//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0102: Expected Obj, but got Unknown
		//IL_0124: Unknown result type (might be due to invalid IL or missing references)
		//IL_012a: Expected Obj, but got Unknown
		//IL_0151: Unknown result type (might be due to invalid IL or missing references)
		//IL_015b: Expected Obj, but got Unknown
		//IL_017d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0183: Expected Obj, but got Unknown
		//IL_01c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c8: Expected Obj, but got Unknown
		//IL_0264: Unknown result type (might be due to invalid IL or missing references)
		//IL_026b: Expected Obj, but got Unknown
		((Control)this).Text = "需要管理员权限";
		((Control)this).Font = new Font("Microsoft YaHei UI", 9f);
		((Form)this).FormBorderStyle = (FormBorderStyle)3;
		((Form)this).MaximizeBox = false;
		((Form)this).MinimizeBox = false;
		((Form)this).ShowInTaskbar = false;
		((Form)this).ShowIcon = false;
		((Form)this).StartPosition = (FormStartPosition)1;
		((Form)this).TopMost = true;
		((Form)this).ClientSize = new Size(392, 224);
		((Control)this).BackColor = Color.White;
		((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
		string text = ((elevatedExes.Count > 4) ? (string.Join("、", ToStrings(elevatedExes).GetRange(0, 4)) + " 等 " + elevatedExes.Count + " 个程序") : string.Join("、", ToStrings(elevatedExes)));
		Label val = new Label();
		((Control)val).Text = "这些程序正以管理员权限运行，暂时隐藏不了：";
		((Control)val).ForeColor = Color.FromArgb(40, 40, 40);
		((Control)val).Font = new Font("Microsoft YaHei UI", 10f, (FontStyle)1);
		((Control)val).Bounds = new Rectangle(20, 18, 352, 24);
		((Control)this).Controls.Add((Control)(object)val);
		Label val2 = new Label();
		((Control)val2).Text = text;
		((Control)val2).ForeColor = Color.FromArgb(178, 92, 10);
		((Control)val2).Font = new Font("Microsoft YaHei UI", 10f, (FontStyle)1);
		((Control)val2).Bounds = new Rectangle(20, 48, 352, 24);
		((Control)this).Controls.Add((Control)(object)val2);
		Label val3 = new Label();
		((Control)val3).Text = "原因是 Windows 的权限隔离：普通权限的程序碰不了管理员程序的窗口。\r\n\r\n要以管理员身份重启摸鱼神器吗？重启后会自动完成本次隐藏，\r\n以后就能正常隐藏这些游戏了。";
		((Control)val3).ForeColor = Color.FromArgb(90, 90, 90);
		((Control)val3).Bounds = new Rectangle(20, 82, 352, 78);
		((Control)this).Controls.Add((Control)(object)val3);
		Button val4 = new Button();
		((Control)val4).Text = "以管理员重启";
		((Control)val4).Bounds = new Rectangle(96, 176, 118, 30);
		((ButtonBase)val4).FlatStyle = (FlatStyle)0;
		((ButtonBase)val4).FlatAppearance.BorderSize = 1;
		((ButtonBase)val4).FlatAppearance.BorderColor = Color.FromArgb(204, 58, 46);
		((ButtonBase)val4).UseVisualStyleBackColor = false;
		((Control)val4).BackColor = Color.FromArgb(204, 58, 46);
		((Control)val4).ForeColor = Color.White;
		((Control)val4).Cursor = Cursors.Hand;
		val4.DialogResult = (DialogResult)6;
		((Control)this).Controls.Add((Control)(object)val4);
		Button val5 = new Button();
		((Control)val5).Text = "先不重启";
		((Control)val5).Bounds = new Rectangle(230, 176, 88, 30);
		((ButtonBase)val5).FlatStyle = (FlatStyle)0;
		((ButtonBase)val5).FlatAppearance.BorderSize = 1;
		((ButtonBase)val5).FlatAppearance.BorderColor = Color.FromArgb(200, 200, 200);
		((ButtonBase)val5).UseVisualStyleBackColor = false;
		((Control)val5).BackColor = Color.White;
		((Control)val5).ForeColor = Color.FromArgb(80, 80, 80);
		((Control)val5).Cursor = Cursors.Hand;
		val5.DialogResult = (DialogResult)7;
		((Control)this).Controls.Add((Control)(object)val5);
		((Form)this).AcceptButton = (IButtonControl)(object)val4;
		((Form)this).CancelButton = (IButtonControl)(object)val5;
	}

	private static List<string> ToStrings(IList<string> source)
	{
		return new List<string>(source);
	}
}
internal sealed class HotKeyManager : IDisposable
{
	// 封装 RegisterHotKey，并将 WM_HOTKEY 转换为 Pressed 事件。
	private const int HotKeyId = 19778;

	private IntPtr _hwnd = IntPtr.Zero;

	private bool _registered;

	public Keys Current { get; private set; }

	public bool IsRegistered => _registered;

	public event EventHandler Pressed;

	public bool Register(IntPtr hwnd, Keys hotKey, out string error)
	{
		// 先注销旧热键，再注册新的组合，避免同一实例重复占用。
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Expected I4, but got Unknown
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		error = null;
		Unregister();
		_hwnd = hwnd;
		Keys val = (Keys)((int)hotKey & 0xFFFF);
		uint num = ToModifiers(hotKey);
		if ((int)val == 0)
		{
			error = "没有识别到主键";
			return false;
		}
		if (num == 0)
		{
			error = "热键至少需要一个修饰键（Ctrl / Alt / Shift / Win）";
			return false;
		}
		if (!Native.RegisterHotKey(hwnd, 19778, num | 0x4000, (uint)(int)val))
		{
			error = "该组合已被其他程序占用，请换一个";
			return false;
		}
		_registered = true;
		Current = hotKey;
		return true;
	}

	public void Unregister()
	{
		if (_registered && _hwnd != IntPtr.Zero)
		{
			Native.UnregisterHotKey(_hwnd, 19778);
			_registered = false;
		}
	}

	public bool HandleMessage(ref Message m)
	{
		if (m.Msg == 786 && m.WParam.ToInt32() == 19778)
		{
			Pressed?.Invoke(this, EventArgs.Empty);
			return true;
		}
		return false;
	}

	public void Dispose()
	{
		Unregister();
	}

	public static uint ToModifiers(Keys hotKey)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Invalid comparison between Unknown and I4
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Invalid comparison between Unknown and I4
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Invalid comparison between Unknown and I4
		uint num = 0u;
		if (((int)hotKey & 0x20000) == 131072)
		{
			num |= 2;
		}
		if (((int)hotKey & 0x40000) == 262144)
		{
			num |= 1;
		}
		if (((int)hotKey & 0x10000) == 65536)
		{
			num |= 4;
		}
		return num;
	}

	public static string Describe(Keys hotKey)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Invalid comparison between Unknown and I4
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Invalid comparison between Unknown and I4
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Invalid comparison between Unknown and I4
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		Keys val = (Keys)((int)hotKey & 0xFFFF);
		if ((int)val == 0)
		{
			return "未设置";
		}
		string text = string.Empty;
		if (((int)hotKey & 0x20000) == 131072)
		{
			text += "Ctrl + ";
		}
		if (((int)hotKey & 0x40000) == 262144)
		{
			text += "Alt + ";
		}
		if (((int)hotKey & 0x10000) == 65536)
		{
			text += "Shift + ";
		}
		return text + KeyName(val);
	}

	private static string KeyName(Keys keyCode)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Invalid comparison between Unknown and I4
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Invalid comparison between Unknown and I4
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Invalid comparison between Unknown and I4
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Invalid comparison between Unknown and I4
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Expected I4, but got Unknown
		if ((int)keyCode >= 48 && (int)keyCode <= 57)
		{
			return ((char)(48 + (keyCode - 48))).ToString();
		}
		if ((int)keyCode >= 96 && (int)keyCode <= 105)
		{
			return "小键盘" + (keyCode - 96);
		}
		return ((object)keyCode/*cast due to constrained. prefix*/).ToString();
	}
}
internal sealed class HotKeyCaptureDialog : Form
{
	// 捕获用户按下的组合键，不接受没有修饰键的单键快捷键。
	private readonly Label _display;

	private readonly Label _hint;

	public Keys Result { get; private set; }

	public HotKeyCaptureDialog(Keys current)
	{
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Expected Obj, but got Unknown
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Expected Obj, but got Unknown
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_009d: Expected Obj, but got Unknown
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e9: Expected Obj, but got Unknown
		//IL_00ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_010b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0115: Expected Obj, but got Unknown
		//IL_0193: Unknown result type (might be due to invalid IL or missing references)
		//IL_019d: Expected Obj, but got Unknown
		Result = (Keys)0;
		((Control)this).Text = "设置老板键";
		((Form)this).FormBorderStyle = (FormBorderStyle)3;
		((Form)this).StartPosition = (FormStartPosition)4;
		((Form)this).MaximizeBox = false;
		((Form)this).MinimizeBox = false;
		((Form)this).ShowInTaskbar = false;
		((Form)this).ClientSize = new Size(340, 160);
		((Control)this).Font = new Font("Microsoft YaHei UI", 9f);
		((Control)this).BackColor = Color.White;
		((Form)this).KeyPreview = true;
		Label val = new Label();
		((Control)val).Text = "请按下新的老板键组合";
		((Control)val).Font = new Font("Microsoft YaHei UI", 10f);
		((Control)val).ForeColor = Color.FromArgb(60, 60, 60);
		((Control)val).AutoSize = false;
		val.TextAlign = (ContentAlignment)32;
		((Control)val).Bounds = new Rectangle(0, 20, 340, 24);
		((Control)this).Controls.Add((Control)(object)val);
		_display = new Label();
		((Control)_display).Text = HotKeyManager.Describe(current);
		((Control)_display).Font = new Font("Consolas", 14f, (FontStyle)1);
		((Control)_display).ForeColor = Color.FromArgb(204, 58, 46);
		((Control)_display).AutoSize = false;
		_display.TextAlign = (ContentAlignment)32;
		((Control)_display).Bounds = new Rectangle(16, 54, 308, 40);
		((Control)_display).BackColor = Color.FromArgb(240, 246, 253);
		((Control)this).Controls.Add((Control)(object)_display);
		_hint = new Label();
		((Control)_hint).Text = "需含 Ctrl / Alt / Shift / Win，Esc 取消";
		((Control)_hint).ForeColor = Color.FromArgb(130, 130, 130);
		((Control)_hint).AutoSize = false;
		_hint.TextAlign = (ContentAlignment)32;
		((Control)_hint).Bounds = new Rectangle(0, 108, 340, 22);
		((Control)this).Controls.Add((Control)(object)_hint);
	}

	protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
	{
		// ProcessCmdKey 能在控件获得焦点时统一拦截键盘组合。
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Invalid comparison between Unknown and I4
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Invalid comparison between Unknown and I4
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Invalid comparison between Unknown and I4
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Invalid comparison between Unknown and I4
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Invalid comparison between Unknown and I4
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Invalid comparison between Unknown and I4
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Invalid comparison between Unknown and I4
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Invalid comparison between Unknown and I4
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Invalid comparison between Unknown and I4
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Invalid comparison between Unknown and I4
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Invalid comparison between Unknown and I4
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ae: Invalid comparison between Unknown and I4
		//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Invalid comparison between Unknown and I4
		//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Invalid comparison between Unknown and I4
		//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bd: Invalid comparison between Unknown and I4
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f5: Unknown result type (might be due to invalid IL or missing references)
		Keys val = (Keys)((int)keyData & 0xFFFF);
		if ((int)val == 17 || (int)val == 16 || (int)val == 18 || (int)val == 91 || (int)val == 92)
		{
			string text = string.Empty;
			if (((int)keyData & 0x20000) == 131072)
			{
				text += "Ctrl + ";
			}
			if (((int)keyData & 0x40000) == 262144)
			{
				text += "Alt + ";
			}
			if (((int)keyData & 0x10000) == 65536)
			{
				text += "Shift + ";
			}
			((Control)_display).Text = text + "…";
			return true;
		}
		if ((int)val == 27)
		{
			((Form)this).DialogResult = (DialogResult)2;
			((Form)this).Close();
			return true;
		}
		if ((int)val == 9 || (int)val == 13 || (int)val == 37 || (int)val == 39 || (int)val == 38 || (int)val == 40)
		{
			return true;
		}
		if (HotKeyManager.ToModifiers(keyData) == 0)
		{
			((Control)_hint).Text = "至少需要 Ctrl / Alt / Shift / Win 中的一个";
			((Control)_hint).ForeColor = Color.FromArgb(190, 70, 70);
			return true;
		}
		Result = keyData;
		((Form)this).DialogResult = (DialogResult)1;
		((Form)this).Close();
		return true;
	}
}
internal static class Log
{
	// 可选的诊断日志；创建 debug.on 文件后才记录普通调试信息。
	public const string DebugSwitchFileName = "debug.on";

	private static readonly object Sync;

	private static readonly bool Verbose;

	private static string LogPath => Path.Combine(AppConfig.DataDir, "log.txt");

	static Log()
	{
		Sync = new object();
		try
		{
			Verbose = File.Exists(Path.Combine(AppConfig.DataDir, "debug.on"));
		}
		catch (Exception)
		{
			Verbose = false;
		}
	}

	public static void Write(string message)
	{
		if (Verbose)
		{
			Append(message);
		}
	}

	public static void Error(string where, Exception ex)
	{
		Append("[ERROR] " + where + ": " + ex.GetType().Name + ": " + ex.Message);
		Append("[STACK] " + ex.StackTrace);
	}

	public static void Clear()
	{
		if (!Verbose)
		{
			return;
		}
		try
		{
			lock (Sync)
			{
				if (File.Exists(LogPath))
				{
					File.Delete(LogPath);
				}
			}
		}
		catch (Exception)
		{
		}
	}

	private static void Append(string message)
	{
		try
		{
			lock (Sync)
			{
				File.AppendAllText(LogPath, DateTime.Now.ToString("HH:mm:ss.fff") + "  " + message + Environment.NewLine);
			}
		}
		catch (Exception)
		{
		}
	}
}
// 轻享版 UI 用的圆角卡片容器：圆角裁剪 + 细边框，营造现代浅色观感。
internal sealed class RoundedPanel : System.Windows.Forms.Panel
{
	public int Radius = 14;
	public Color BorderColor = Color.FromArgb(228, 232, 240);
	public int BorderThickness = 1;

	public RoundedPanel()
	{
		DoubleBuffered = true;
		ResizeRedraw = true;
	}

	private static System.Drawing.Drawing2D.GraphicsPath RoundPath(Rectangle r, int radius)
	{
		System.Drawing.Drawing2D.GraphicsPath p = new System.Drawing.Drawing2D.GraphicsPath();
		int d = radius * 2;
		if (d <= 0 || d > r.Width || d > r.Height)
		{
			p.AddRectangle(r);
			p.CloseFigure();
			return p;
		}
		p.AddArc(r.X, r.Y, d, d, 180, 90);
		p.AddArc(r.Right - d, r.Y, d, d, 270, 90);
		p.AddArc(r.Right - d, r.Bottom - d, d, d, 0, 90);
		p.AddArc(r.X, r.Bottom - d, d, d, 90, 90);
		p.CloseFigure();
		return p;
	}

	protected override void OnResize(EventArgs e)
	{
		base.OnResize(e);
		if (Width <= 0 || Height <= 0) return;
		using (System.Drawing.Drawing2D.GraphicsPath gp = RoundPath(new Rectangle(0, 0, Width, Height), Radius))
		{
			Region = new Region(gp);
		}
	}

	protected override void OnPaint(System.Windows.Forms.PaintEventArgs e)
	{
		base.OnPaint(e);
		e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
		using (System.Drawing.Drawing2D.GraphicsPath gp = RoundPath(new Rectangle(0, 0, Width - 1, Height - 1), Radius))
		using (Pen pen = new Pen(BorderColor, BorderThickness))
		{
			e.Graphics.DrawPath(pen, gp);
		}
	}
}
// 朱砂开关：替代原生复选框（原生勾选是系统蓝，会破坏「朱批·隐」配色）。关=灰轨，开=朱砂轨。
internal sealed class ToggleSwitch : System.Windows.Forms.Control
{
	private bool _checked;
	public event EventHandler CheckedChanged;
	public Color OnColor = Color.FromArgb(204, 58, 46);
	public Color OffColor = Color.FromArgb(206, 210, 208);

	public ToggleSwitch()
	{
		DoubleBuffered = true;
		Size = new Size(46, 26);
		Cursor = Cursors.Hand;
		TabStop = true;
	}

	public bool Checked
	{
		get { return _checked; }
		set
		{
			if (_checked == value) return;
			_checked = value;
			Invalidate();
			if (CheckedChanged != null) CheckedChanged(this, EventArgs.Empty);
		}
	}

	protected override void OnClick(EventArgs e) { Checked = !_checked; base.OnClick(e); }

	protected override void OnPaint(System.Windows.Forms.PaintEventArgs e)
	{
		var g = e.Graphics;
		g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
		int h = Height, w = Width, r = h / 2;
		Rectangle track = new Rectangle(0, 0, w - 1, h - 1);
		using (var path = new System.Drawing.Drawing2D.GraphicsPath())
		{
			path.AddArc(track.X, track.Y, h - 1, h - 1, 90, 180);
			path.AddArc(track.Right - (h - 1), track.Y, h - 1, h - 1, 270, 180);
			path.CloseFigure();
			using (var b = new SolidBrush(_checked ? OnColor : OffColor)) g.FillPath(b, path);
		}
		int knob = h - 8;
		int kx = _checked ? (w - knob - 4) : 4;
		using (var b = new SolidBrush(Color.White)) g.FillEllipse(b, kx, 4, knob, knob);
	}
}
// 轻享版共用的视觉常量与高 DPI 缩放。进程为 DPI 感知（manifest），字体用磅值随 DPI 清晰渲染，
// 这里把整棵控件树与窗口尺寸按同比例放大，使版面与字号一致、无白边。
internal static class Ui
{
	public static readonly Color Bg         = Color.FromArgb(239, 241, 240);
	public static readonly Color Card       = Color.White;
	public static readonly Color Border     = Color.FromArgb(216, 220, 218);
	public static readonly Color Seal        = Color.FromArgb(204, 58, 46);
	public static readonly Color SealDeep    = Color.FromArgb(168, 46, 36);
	public static readonly Color Text       = Color.FromArgb(26, 30, 36);
	public static readonly Color Muted      = Color.FromArgb(88, 95, 104);

	public static void ScaleToDpi(Form f)
	{
		float s;
		using (Graphics g = f.CreateGraphics()) { s = g.DpiX / 96f; }
		if (s <= 1.01f) return;
		ScaleTree(f, s);
		f.ClientSize = new Size((int)Math.Round(f.ClientSize.Width * s), (int)Math.Round(f.ClientSize.Height * s));
	}

	private static void ScaleTree(Control parent, float s)
	{
		foreach (Control c in parent.Controls)
		{
			c.Bounds = new Rectangle(
				(int)Math.Round(c.Left * s), (int)Math.Round(c.Top * s),
				(int)Math.Round(c.Width * s), (int)Math.Round(c.Height * s));
			RoundedPanel rp = c as RoundedPanel;
			if (rp != null) rp.Radius = (int)Math.Round(rp.Radius * s);
			ScaleTree(c, s);
		}
	}
}
// 首次运行提示：声明本版永久免费 + 反欺诈举报，并给出官网入口。
internal sealed class FreeNoticeDialog : Form
{
	private const string SiteUrl = "https://bosskey.pages.dev";

	public FreeNoticeDialog()
	{
		Text = "此版本永久免费";
		Font = new Font("Microsoft YaHei UI", 9f);
		FormBorderStyle = FormBorderStyle.FixedDialog;
		MaximizeBox = false;
		MinimizeBox = false;
		ShowInTaskbar = false;
		ShowIcon = false;
		StartPosition = FormStartPosition.CenterParent;
		BackColor = Ui.Bg;
		ClientSize = new Size(400, 236);

		RoundedPanel seal = new RoundedPanel();
		seal.Bounds = new Rectangle(28, 26, 40, 40);
		seal.BackColor = Ui.Seal; seal.BorderColor = Ui.SealDeep; seal.Radius = 9;
		Controls.Add(seal);
		AddLabel(seal, "隐", 0, 0, 40, 40, new Font("Microsoft YaHei UI", 19f, FontStyle.Bold), Color.White, ContentAlignment.MiddleCenter);

		AddLabel(this, "此版本永久免费", 82, 24, 290, 26, new Font("Microsoft YaHei UI", 14f, FontStyle.Bold), Ui.Text, ContentAlignment.MiddleLeft);
		AddLabel(this, "若您是花钱买来的，说明有人冒充本软件收费。\r\n请立即退款并举报，官网永久免费下载：",
			82, 56, 300, 50, new Font("Microsoft YaHei UI", 9f), Ui.Muted, ContentAlignment.TopLeft);

		Button site = new Button();
		site.Text = "访问官网  bosskey.pages.dev";
		site.Bounds = new Rectangle(28, 118, 344, 44);
		site.FlatStyle = FlatStyle.Flat;
		site.FlatAppearance.BorderSize = 0;
		site.UseVisualStyleBackColor = false;
		site.BackColor = Ui.Seal;
		site.ForeColor = Color.White;
		site.Font = new Font("Microsoft YaHei UI", 10.5f, FontStyle.Bold);
		site.Cursor = Cursors.Hand;
		site.Click += delegate { OpenSite(); };
		Controls.Add(site);

		Button ok = new Button();
		ok.Text = "我知道了";
		ok.Bounds = new Rectangle(28, 176, 344, 36);
		ok.FlatStyle = FlatStyle.Flat;
		ok.FlatAppearance.BorderSize = 1;
		ok.FlatAppearance.BorderColor = Ui.Border;
		ok.UseVisualStyleBackColor = false;
		ok.BackColor = Ui.Card;
		ok.ForeColor = Ui.Text;
		ok.Font = new Font("Microsoft YaHei UI", 9f);
		ok.Cursor = Cursors.Hand;
		ok.DialogResult = DialogResult.OK;
		Controls.Add(ok);
		AcceptButton = ok;

		Ui.ScaleToDpi(this);
	}

	private static void AddLabel(Control parent, string text, int x, int y, int w, int h, Font font, Color color, ContentAlignment align)
	{
		Label l = new Label();
		l.Text = text; l.Bounds = new Rectangle(x, y, w, h);
		l.Font = font; l.ForeColor = color; l.TextAlign = align; l.BackColor = Color.Transparent;
		parent.Controls.Add(l);
	}

	private void OpenSite()
	{
		try { Process.Start(new ProcessStartInfo(SiteUrl) { UseShellExecute = true }); }
		catch (Exception)
		{
			MessageBox.Show("请在浏览器打开：" + SiteUrl, "官网", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}
	}
}
internal sealed class MainForm : Form
{
	// 主窗口和应用控制器：负责托盘、配置、热键以及隐藏/恢复流程。
	private static readonly uint WM_SHOWME = Native.RegisterWindowMessage("MoyuBossKeyLite_ShowMe");

	private const int WM_SETICON = 128;

	private const int ICON_SMALL = 0;

	private readonly AppConfig _config;

	private readonly HotKeyManager _hotKeys = new HotKeyManager();

	private readonly NotifyIcon _tray = new NotifyIcon();

	private readonly Label _statusLabel = new Label();

	private readonly Label _hotKeyValue = new Label();

	private readonly Label _programSummary = new Label();

	private readonly Label _hintLabel = new Label();

	private readonly ToggleSwitch _chkAutoStart = new ToggleSwitch();

	private readonly ToggleSwitch _chkPauseMedia = new ToggleSwitch();

	private readonly Button _btnPick = new Button();

	private readonly Icon _appIcon;

	private readonly Icon _appIconSmall;

	private List<IntPtr> _hiddenWindows = new List<IntPtr>();
	private readonly Dictionary<IntPtr, uint> _hiddenWindowOwners = new Dictionary<IntPtr, uint>();
	private readonly System.Windows.Forms.Timer _hideGuard = new System.Windows.Forms.Timer();
	private readonly System.Windows.Forms.Timer _captureGuard = new System.Windows.Forms.Timer();
	// 自身 PID 运行期不变，缓存一次，避免隐藏/防录屏热路径每次都 new 一个 Process 对象。
	private readonly uint _selfPid = (uint)Process.GetCurrentProcess().Id;
	private WindowShowWatcher _windowShowWatcher;
	private bool _hiddenStateDirty, _handlingWindowShow;

	private List<string> _hiddenTrayExes = new List<string>();

	private bool _isHidden;

	private bool _selfWasVisible;

	private bool _reallyExit;

	private bool _suppressEvents = true;

	private IntPtr _foregroundBefore = IntPtr.Zero;

	private readonly bool _autoHideOnStart;

	private bool _autoHideDone;

	private bool _elevationNagged;

	public MainForm(bool autoHideOnStart)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected Obj, but got Unknown
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected Obj, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected Obj, but got Unknown
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected Obj, but got Unknown
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Expected Obj, but got Unknown
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected Obj, but got Unknown
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected Obj, but got Unknown
		//IL_013c: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ba: Expected Obj, but got Unknown
		_autoHideOnStart = autoHideOnStart;
		_config = AppConfig.Load();
		_appIcon = LoadOwnIcon(wantLarge: true);
		_appIconSmall = LoadOwnIcon(wantLarge: false);
		BuildUi();
		BuildTray();
		_hideGuard.Interval = 300;
		_hideGuard.Tick += delegate { MaintainHiddenWindows(); };
		_captureGuard.Interval = 1500;
		_captureGuard.Tick += delegate { ApplyCaptureGuard(); };
		// 防录屏只在按下快捷键进入隐身后才启用，启动阶段不拦截捕获。
		CaptureGuard.Enabled = false;
		_hotKeys.Pressed += delegate
		{
			ToggleMoyu();
		};
		((Form)this).Icon = _appIcon;
		ApplySmallIcon();
		_suppressEvents = false;
		ApplyConfigToUi();
		RegisterHotKeyFromConfig();
		GC.KeepAlive(((Control)this).Handle);
		Log.Write("=== app started pid=" + Process.GetCurrentProcess().Id + " hotkey=" + HotKeyManager.Describe(_config.HotKey) + " 名单=" + DescribeFilter() + " 提权=" + (Native.SelfIsElevated ? "管理员" : "普通") + (_autoHideOnStart ? " auto-hide-now" : "") + " ===");
		if (_autoHideOnStart)
		{
			((Control)this).BeginInvoke((Delegate)(MethodInvoker)(() =>
			{
				_autoHideDone = true;
				Log.Write("auto-hide-now: 执行 HideEverything");
				HideEverything();
			}));
		}
		else if (!_config.FreeNoticeShown)
		{
			// 仅首次运行弹一次「永久免费 + 反欺诈举报」提示，之后不再弹。
			((Control)this).BeginInvoke((Delegate)(MethodInvoker)(() =>
			{
				ShowFreeNotice();
				_config.FreeNoticeShown = true;
				_config.Save();
			}));
		}
	}

	private void ShowFreeNotice()
	{
		try
		{
			using (FreeNoticeDialog d = new FreeNoticeDialog())
			{
				d.ShowDialog(this);
			}
		}
		catch (Exception ex) { Log.Error("ShowFreeNotice", ex); }
	}

	protected override void SetVisibleCore(bool value)
	{
		if ((_autoHideOnStart && !_autoHideDone) & value)
		{
			value = false;
		}
		base.SetVisibleCore(value);
	}

	private string DescribeFilter()
	{
		if (!_config.HasProcessFilter)
		{
			return "(空 → 不隐藏任何窗口)";
		}
		return string.Join(",", _config.HideProcesses.ToArray());
	}

	protected override void OnHandleCreated(EventArgs e)
	{
		base.OnHandleCreated(e);
		if (_config != null)
		{
			RegisterHotKeyFromConfig();
		}
		ApplySmallIcon();
		// 启动时不设防录屏；等快捷键隐身后再对窗口生效。
	}

	private void ApplySmallIcon()
	{
		if (_appIconSmall != null)
		{
			Native.SendMessage(((Control)this).Handle, 128, (IntPtr)0, _appIconSmall.Handle);
		}
	}

	// === 轻享版 UI：「朱批·隐」——墨色账簿纸上一枚朱砂印章/按键，与官网同一套视觉 ===
	private static readonly Color UiBg        = Color.FromArgb(239, 241, 240);  // 瓷白 porcelain
	private static readonly Color UiCard      = Color.White;
	private static readonly Color UiBorder    = Color.FromArgb(216, 220, 218);  // 细线 hairline
	private static readonly Color UiAccent    = Color.FromArgb(204, 58, 46);    // 朱砂 cinnabar（唯一强调色）
	private static readonly Color UiAccentDeep = Color.FromArgb(168, 46, 36);
	private static readonly Color UiAccentSoft= Color.FromArgb(247, 230, 227);  // 朱砂淡
	private static readonly Color UiText      = Color.FromArgb(26, 30, 36);      // 墨 ink
	private static readonly Color UiMuted     = Color.FromArgb(88, 95, 104);
	private static readonly Color UiAmber     = Color.FromArgb(180, 110, 20);

	private RoundedPanel Card(int x, int y, int w, int h, Color? bg = null, Color? border = null)
	{
		RoundedPanel p = new RoundedPanel();
		p.Bounds = new Rectangle(x, y, w, h);
		p.BackColor = bg ?? UiCard;
		p.BorderColor = border ?? UiBorder;
		p.Radius = 14;
		Controls.Add(p);
		return p;
	}

	private static Label Lbl(Control parent, string text, int x, int y, int w, int h,
		Font font, Color color, ContentAlignment align = ContentAlignment.MiddleLeft)
	{
		Label l = new Label();
		l.Text = text;
		l.Bounds = new Rectangle(x, y, w, h);
		l.Font = font;
		l.ForeColor = color;
		l.TextAlign = align;
		l.BackColor = Color.Transparent;
		parent.Controls.Add(l);
		return l;
	}

	private void BuildUi()
	{
		Font fTitle  = new Font("Microsoft YaHei UI", 17f, FontStyle.Bold);
		Font fBadge  = new Font("Microsoft YaHei UI", 8.5f, FontStyle.Bold);
		Font fLabel  = new Font("Microsoft YaHei UI", 9f);
		Font fSmall  = new Font("Microsoft YaHei UI", 8.5f);
		Font fRow    = new Font("Microsoft YaHei UI", 10f, FontStyle.Bold);
		Font fKey    = new Font("Consolas", 17f, FontStyle.Bold);

		this.Text = "一键隐身·轻享版";
		this.Font = fLabel;
		this.FormBorderStyle = FormBorderStyle.FixedSingle;
		this.MaximizeBox = false;
		this.StartPosition = FormStartPosition.CenterScreen;
		this.ClientSize = new Size(432, 584);
		this.BackColor = UiBg;
		// 自己按 DPI 缩放（见 BuildUi 末尾 ScaleTree），这里关掉 WinForms 自动缩放避免二次缩放。
		this.AutoScaleMode = AutoScaleMode.None;

		int M = 20;              // 页边距
		int W = 432 - M * 2;     // 卡片宽度 = 392

		// —— 顶部：朱砂印章「隐」（唯一强调色）+ 标题 + 安静的版本小字 ——
		RoundedPanel seal = new RoundedPanel();
		seal.Bounds = new Rectangle(M, 18, 34, 34);
		seal.BackColor = UiAccent;
		seal.BorderColor = UiAccentDeep;
		seal.Radius = 8;
		Controls.Add(seal);
		Lbl(seal, "隐", 0, -1, 34, 34, new Font("Microsoft YaHei UI", 16f, FontStyle.Bold), Color.White, ContentAlignment.MiddleCenter);
		Lbl(this, "一键隐身", M + 46, 17, 150, 28, fTitle, UiText);
		// 版本：安静灰字，不再用第二块红色，避免与印章抢视觉
		Lbl(this, "免费 · 轻享版", M + W - 108, 24, 108, 18, fBadge, UiMuted, ContentAlignment.MiddleRight);
		Lbl(this, "一键隐藏指定窗口，隐身时自动静音并暂停播放", M + 46, 45, W - 46, 18, fSmall, UiMuted);

		// —— 老板键卡片（按键造型）——
		int y = 82;
		RoundedPanel cHot = Card(M, y, W, 92);
		Lbl(cHot, "老板键（全局快捷键）", 18, 12, 240, 18, fSmall, UiMuted);
		// 键帽：白底、底边加厚（朱砂）营造实体按键感
		int capW = 300;
		RoundedPanel keycap = new RoundedPanel();
		keycap.Bounds = new Rectangle(18, 36, capW, 42);
		keycap.BackColor = UiCard;
		keycap.BorderColor = UiBorder;
		keycap.Radius = 8;
		cHot.Controls.Add(keycap);
		RoundedPanel keyedge = new RoundedPanel();   // 底部朱砂边 = 按键厚度
		keyedge.Bounds = new Rectangle(18, 73, capW, 6);
		keyedge.BackColor = UiAccent;
		keyedge.BorderColor = UiAccent;
		keyedge.Radius = 3;
		cHot.Controls.Add(keyedge);
		keycap.BringToFront();
		_hotKeyValue.Text = "Ctrl + Alt + Q";
		_hotKeyValue.Font = new Font("Consolas", 15f, FontStyle.Bold);
		_hotKeyValue.ForeColor = UiText;
		_hotKeyValue.TextAlign = ContentAlignment.MiddleCenter;
		_hotKeyValue.BackColor = Color.Transparent;
		_hotKeyValue.Bounds = new Rectangle(0, 0, capW, 42);
		keycap.Controls.Add(_hotKeyValue);
		LinkLabel lnk = new LinkLabel();
		lnk.Text = "修改";
		lnk.Font = fLabel;
		lnk.LinkColor = UiAccent;
		lnk.ActiveLinkColor = UiAccentDeep;
		lnk.LinkBehavior = LinkBehavior.HoverUnderline;
		lnk.TextAlign = ContentAlignment.MiddleCenter;
		lnk.BackColor = Color.Transparent;
		lnk.Bounds = new Rectangle(W - 62, 46, 48, 24);
		lnk.LinkClicked += delegate { ChangeHotKey(); };
		cHot.Controls.Add(lnk);

		// —— 要隐藏的程序卡片 ——
		y += 104;
		RoundedPanel cApp = Card(M, y, W, 96);
		Lbl(cApp, "要隐藏的程序", 18, 12, 220, 18, fSmall, UiMuted);
		_programSummary.AutoEllipsis = true;
		_programSummary.Bounds = new Rectangle(18, 34, W - 140, 48);
		_programSummary.Font = fLabel;
		_programSummary.ForeColor = UiText;
		_programSummary.BackColor = Color.Transparent;
		_programSummary.TextAlign = ContentAlignment.TopLeft;
		cApp.Controls.Add(_programSummary);
		_btnPick.Text = "选择程序…";
		_btnPick.Bounds = new Rectangle(W - 112, 30, 94, 36);
		_btnPick.FlatStyle = FlatStyle.Flat;
		_btnPick.FlatAppearance.BorderSize = 0;
		_btnPick.UseVisualStyleBackColor = false;
		_btnPick.BackColor = UiAccent;
		_btnPick.ForeColor = Color.White;
		_btnPick.Font = fLabel;
		_btnPick.Cursor = Cursors.Hand;
		_btnPick.Click += delegate { PickProgram(); };
		cApp.Controls.Add(_btnPick);

		// —— 开关区（功能拆开独立显示）——
		y += 108;
		Lbl(this, "开关", M + 4, y, W, 18, fSmall, UiMuted);
		y += 24;
		BuildToggleRow(M, y, W, fRow, fSmall, _chkAutoStart,
			"开机自动启动", "登录 Windows 后自动运行");
		y += 68;
		BuildToggleRow(M, y, W, fRow, fSmall, _chkPauseMedia,
			"隐身时静音并暂停", "静音被隐藏程序的声音（含 Chrome 网页视频）并暂停播放，恢复时还原");

		// —— 提示 + 状态 ——
		y += 76;
		_hintLabel.Text = "按下老板键即隐藏所选程序，再按一次恢复";
		_hintLabel.Font = fSmall;
		_hintLabel.ForeColor = UiAmber;
		_hintLabel.TextAlign = ContentAlignment.MiddleCenter;
		_hintLabel.BackColor = Color.Transparent;
		_hintLabel.Bounds = new Rectangle(M, y, W, 20);
		Controls.Add(_hintLabel);
		y += 24;
		_statusLabel.Text = "状态：待命";
		_statusLabel.Font = fSmall;
		_statusLabel.ForeColor = UiMuted;
		_statusLabel.TextAlign = ContentAlignment.MiddleCenter;
		_statusLabel.BackColor = Color.Transparent;
		_statusLabel.Bounds = new Rectangle(M, y, W, 20);
		Controls.Add(_statusLabel);

		// —— 底部 ——
		y += 26;
		Lbl(this, "关闭窗口 = 最小化到托盘，程序继续运行", M, y, W, 16,
			new Font("Microsoft YaHei UI", 8f), Color.FromArgb(170, 178, 190),
			ContentAlignment.MiddleCenter);
		y += 22;
		Button about = new Button();
		about.Text = "关于作者";
		about.Bounds = new Rectangle((432 - 112) / 2, y, 112, 30);
		about.FlatStyle = FlatStyle.Flat;
		about.FlatAppearance.BorderSize = 1;
		about.FlatAppearance.BorderColor = UiBorder;
		about.UseVisualStyleBackColor = false;
		about.BackColor = UiCard;
		about.ForeColor = UiText;
		about.Font = fSmall;
		about.Cursor = Cursors.Hand;
		about.Click += delegate { ShowAboutAuthor(); };
		Controls.Add(about);

		// 高 DPI：按系统缩放把整棵控件树和窗口放大，字体用磅值随 DPI 清晰渲染。
		Ui.ScaleToDpi(this);
	}

	// 一行独立开关：标题 + 说明 + 右侧勾选框，整张卡片点一下即可切换。
	private void BuildToggleRow(int x, int y, int w, Font fRow, Font fSub, ToggleSwitch sw,
		string title, string sub)
	{
		RoundedPanel card = Card(x, y, w, 62);
		Lbl(card, title, 18, 10, w - 90, 22, fRow, UiText);
		Lbl(card, sub, 18, 33, w - 86, 18, fSub, UiMuted);
		sw.Bounds = new Rectangle(w - 64, 18, 46, 26);
		sw.BackColor = UiCard;
		sw.CheckedChanged += delegate { OnOptionChanged(); };
		card.Controls.Add(sw);
		// 点卡片任意处 = 切换开关
		EventHandler toggle = delegate { sw.Checked = !sw.Checked; };
		card.Click += toggle;
		foreach (Control c in card.Controls)
		{
			if (!(c is ToggleSwitch)) { c.Cursor = Cursors.Hand; c.Click += toggle; }
		}
	}

	private void ShowAboutAuthor()
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		AboutAuthorDialog aboutAuthorDialog = new AboutAuthorDialog();
		try
		{
			((Form)aboutAuthorDialog).ShowDialog((IWin32Window)(object)this);
		}
		finally
		{
			((IDisposable)(object)aboutAuthorDialog)?.Dispose();
		}
	}

	private void BuildTray()
	{
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Expected Obj, but got Unknown
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Expected Obj, but got Unknown
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Expected Obj, but got Unknown
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Expected Obj, but got Unknown
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Expected Obj, but got Unknown
		_tray.Icon = _appIconSmall;
		_tray.Text = "一键隐身·轻享版";
		_tray.Visible = true;
		_tray.DoubleClick += delegate
		{
			ShowMainWindow();
		};
		ContextMenuStrip val = new ContextMenuStrip();
		((Control)val).Font = new Font("Microsoft YaHei UI", 9f);
		ToolStripMenuItem val2 = new ToolStripMenuItem("显示主窗口");
		((ToolStripItem)val2).Click += delegate
		{
			ShowMainWindow();
		};
		((ToolStrip)val).Items.Add((ToolStripItem)(object)val2);
        ToolStripMenuItem contactAuthor = new ToolStripMenuItem("联系作者");
        contactAuthor.ToolTipText = "Telegram：@ydnw6 ｜ QQ：959649446";
        contactAuthor.Click += delegate
        {
            try
            {
                Process.Start(new ProcessStartInfo("https://t.me/ydnw6") { UseShellExecute = true });
            }
            catch (Exception)
            {
                MessageBox.Show("无法打开浏览器，请访问：https://t.me/ydnw6", "联系作者", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        };
        val.Items.Add(contactAuthor);
		((ToolStrip)val).Items.Add((ToolStripItem)new ToolStripSeparator());
		if (!Native.SelfIsElevated)
		{
			ToolStripMenuItem runAdmin = new ToolStripMenuItem("以管理员身份重启");
			runAdmin.ToolTipText = "重启并提权，才能隐藏以管理员身份运行的程序";
			((ToolStripItem)runAdmin).Click += delegate { RestartElevatedManual(); };
			((ToolStrip)val).Items.Add((ToolStripItem)(object)runAdmin);
		}
		else
		{
			ToolStripMenuItem isAdmin = new ToolStripMenuItem("已是管理员权限 ✓");
			((ToolStripItem)isAdmin).Enabled = false;
			((ToolStrip)val).Items.Add((ToolStripItem)(object)isAdmin);
		}
		((ToolStrip)val).Items.Add((ToolStripItem)new ToolStripSeparator());
		ToolStripMenuItem val3 = new ToolStripMenuItem("退出");
		((ToolStripItem)val3).Click += delegate
		{
			ExitApp();
		};
		((ToolStrip)val).Items.Add((ToolStripItem)(object)val3);
		_tray.ContextMenuStrip = val;
	}

	private void PickProgram()
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Invalid comparison between Unknown and I4
		ProgramPickerDialog programPickerDialog = new ProgramPickerDialog(_config.HideProcesses);
		try
		{
			if ((int)((Form)programPickerDialog).ShowDialog((IWin32Window)(object)this) == 1)
			{
				_config.HideProcesses.Clear();
				_config.HideProcesses.AddRange(programPickerDialog.Selected);
				_config.Save();
				UpdateProgramSummary();
				SetStatus(_config.HasProcessFilter ? ("已指定 " + _config.HideProcesses.Count + " 个程序，老板键只隐藏它们") : "还没有指定程序，老板键不会隐藏任何窗口");
			}
		}
		finally
		{
			((IDisposable)(object)programPickerDialog)?.Dispose();
		}
	}

	private void UpdateProgramSummary()
	{
		int count = _config.HideProcesses.Count;
		if (count == 0)
		{
			((Control)_programSummary).Text = "未指定，请先选择要隐藏的程序";
			((Control)_programSummary).ForeColor = UiAmber;
			((Control)_hintLabel).Text = "先点右侧「选择程序…」，否则老板键不会有反应";
			((Control)_hintLabel).ForeColor = UiAmber;
			return;
		}
		List<string> list = new List<string>();
		for (int i = 0; i < count && i < 3; i++)
		{
			list.Add(PrettyName(_config.HideProcesses[i]));
		}
		string text = "已选 " + count + " 个：" + string.Join("、", list.ToArray());
		if (count > list.Count)
		{
			text += " 等";
		}
		((Control)_programSummary).Text = text;
		((Control)_programSummary).ForeColor = UiText;
		((Control)_hintLabel).Text = "按下老板键即隐藏所选程序，再按一次恢复";
		((Control)_hintLabel).ForeColor = UiMuted;
	}

	private static string PrettyName(string exe)
	{
		string text = ((exe == null) ? string.Empty : exe);
		if (text.EndsWith(".exe", StringComparison.OrdinalIgnoreCase))
		{
			text = text.Substring(0, text.Length - 4);
		}
		if (text.Length > 0)
		{
			text = char.ToUpperInvariant(text[0]) + text.Substring(1);
		}
		return text;
	}

	private void RegisterHotKeyFromConfig()
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
		if (!_hotKeys.Register(((Control)this).Handle, _config.HotKey, out var error))
		{
			Log.Write("hotkey FAILED for " + HotKeyManager.Describe(_config.HotKey) + " : " + error);
			Keys val = (Keys)393339;
			if (_config.HotKey != val && _hotKeys.Register(((Control)this).Handle, val, out error))
			{
				_config.HotKey = val;
				_config.Save();
				((Control)_hotKeyValue).Text = HotKeyManager.Describe(val);
				SetStatus("老板键被占用，已临时改用 " + HotKeyManager.Describe(val));
				Log.Write("hotkey fallback -> " + HotKeyManager.Describe(val));
			}
			else
			{
				SetStatus("热键注册失败：" + error);
			}
		}
		else
		{
			Log.Write("hotkey registered: " + HotKeyManager.Describe(_config.HotKey) + " hwnd=0x" + ((Control)this).Handle.ToInt64().ToString("X"));
		}
	}

	private void ChangeHotKey()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Invalid comparison between Unknown and I4
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		HotKeyCaptureDialog hotKeyCaptureDialog = new HotKeyCaptureDialog(_config.HotKey);
		try
		{
			if ((int)((Form)hotKeyCaptureDialog).ShowDialog((IWin32Window)(object)this) == 1)
			{
				if (!_hotKeys.Register(((Control)this).Handle, hotKeyCaptureDialog.Result, out var error))
				{
					MessageBox.Show((IWin32Window)(object)this, error, "热键设置失败", (MessageBoxButtons)0, (MessageBoxIcon)48);
					RegisterHotKeyFromConfig();
					return;
				}
				_config.HotKey = hotKeyCaptureDialog.Result;
				_config.Save();
				((Control)_hotKeyValue).Text = HotKeyManager.Describe(_config.HotKey);
				SetStatus("老板键已更新为 " + HotKeyManager.Describe(_config.HotKey));
			}
		}
		finally
		{
			((IDisposable)(object)hotKeyCaptureDialog)?.Dispose();
		}
	}
    private void ToggleMoyu()
	{
		if (_isHidden)
		{
			RestoreEverything();
		}
		else
		{
			HideEverything();
		}
	}

	private void HideEverything()
	{
		// 按进程名单收集目标窗口，同时处理权限、托盘图标和状态持久化。
		//IL_00d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00de: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ff: Invalid comparison between Unknown and I4
		if (_isHidden)
		{
			return;
		}
		if (!_config.HasProcessFilter)
		{
			Log.Write("HideEverything 跳过：名单为空");
			SetStatus("请先点「选择程序…」指定要隐藏的程序");
			ShowTrayBalloon("还没有选择要隐藏的程序。请打开主窗口，点「选择程序…」勾选目标程序后再按老板键。");
			return;
		}
		try
		{
			Log.Write("=== HideEverything begin === 名单=" + DescribeFilter());
			_foregroundBefore = Native.GetForegroundWindow();
			_selfWasVisible = ((Control)this).Visible;
			uint id = (uint)Process.GetCurrentProcess().Id;
			List<WindowHider.HideTarget> list = WindowHider.CollectTargets(((Control)this).Handle, id, _config.HideProcesses, out var elevatedExes);
			if (elevatedExes.Count > 0 && !Native.SelfIsElevated && !_elevationNagged && !_autoHideOnStart)
			{
				Log.Write("检测到提权程序: " + string.Join(",", elevatedExes.ToArray()));
				ElevatedPromptDialog elevatedPromptDialog = new ElevatedPromptDialog(elevatedExes);
				try
				{
					DialogResult val = ((Form)elevatedPromptDialog).ShowDialog((IWin32Window)(object)this);
					Log.Write("ElevatedPromptDialog -> " + ((object)val/*cast due to constrained. prefix*/).ToString());
					if ((int)val == 6 && RestartElevated())
					{
						return;
					}
				}
				finally
				{
					((IDisposable)(object)elevatedPromptDialog)?.Dispose();
				}
				_elevationNagged = true;
			}
			_hiddenWindows = WindowHider.Hide(list, out var failed);
			_hiddenWindowOwners.Clear();
			foreach (var target in list)
				if (_hiddenWindows.Contains(target.Hwnd)) _hiddenWindowOwners[target.Hwnd] = target.Pid;
			Log.Write("WindowHider.Hide -> " + _hiddenWindows.Count + " / targets " + list.Count + " failed " + failed.Count);
			// 轻享版：不摘除托盘图标，只隐藏窗口。
			_hiddenTrayExes = new List<string>();
			ShellHider.EnsureTaskbarVisible();
			{ HiddenStateStore.Save(_hiddenWindows, _hiddenTrayExes); _hiddenStateDirty = false; }
			_isHidden = true;
			// 轻享版特色：隐身时暂停正在播放的音/视频。
			if (_config.PauseMedia)
			{
				AudioMute.SetMuted(_config.HideProcesses, true);   // 可靠：直接静音被隐藏程序（含 Chrome 网页视频）
				Native.TapMediaPlayPause();                        // 尽力：暂停支持媒体键的播放器（YouTube 等）
				Log.Write("PauseMedia -> 静音名单 + 发送媒体暂停键");
			}
			try { _windowShowWatcher = new WindowShowWatcher(HideShownWindow); }
			catch (Exception ex) { Log.Error("StartWindowShowWatcher", ex); }
			_hideGuard.Start();
			if (failed.Count > 0)
			{
				List<string> list2 = new List<string>();
				foreach (WindowHider.HideTarget item in failed)
				{
					if (!list2.Contains(item.Exe))
					{
						list2.Add(item.Exe);
					}
				}
				ShowTrayBalloon(string.Join("、", list2.ToArray()) + " 以管理员权限运行，普通权限隐藏不了。右键摸鱼神器选「以管理员身份运行」后即可隐藏。");
			}
			_tray.Visible = false;
			((Control)this).Hide();
			Log.Write("托盘图标已摘除（NotifyIcon.Visible=false → NIM_DELETE）");
			Log.Write("self hidden done, form.Visible=" + ((Control)this).Visible + " hiddenWindows=" + _hiddenWindows.Count);
		}
		catch (Exception ex)
		{
			Log.Error("HideEverything", ex);
		}
		SetStatus(HideStatusText());
	}

	private string HideStatusText()
	{
		string s = "已隐藏 " + _hiddenWindows.Count + " 个窗口";
		if (_config.PauseMedia) { s += "，已静音并暂停"; }
		return s;
	}

	private void RestartElevatedManual()
	{
		try
		{
			Process.Start(new ProcessStartInfo
			{
				FileName = Application.ExecutablePath,
				Arguments = "--elevated-restart",
				UseShellExecute = true,
				Verb = "runas"
			});
			Log.Write("RestartElevatedManual -> 新实例已请求（管理员），本实例退出");
			_reallyExit = true;
			((Control)this).BeginInvoke((Delegate)(MethodInvoker)(() =>
			{
				((Form)this).Close();
			}));
		}
		catch (Win32Exception ex)
		{
			Log.Write("RestartElevatedManual 用户取消/失败: " + ex.Message);
		}
		catch (Exception ex2)
		{
			Log.Error("RestartElevatedManual", ex2);
		}
	}
	private bool RestartElevated()
	{
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Expected Obj, but got Unknown
		try
		{
			Process.Start(new ProcessStartInfo
			{
				FileName = Application.ExecutablePath,
				Arguments = "--hide-now",
				UseShellExecute = true,
				Verb = "runas"
			});
			Log.Write("RestartElevated -> 新实例已请求，本实例退出");
			_reallyExit = true;
			((Control)this).BeginInvoke((Delegate)(MethodInvoker)(() =>
			{
				((Form)this).Close();
			}));
			return true;
		}
		catch (Win32Exception ex)
		{
			Log.Write("RestartElevated 取消/失败: " + ex.Message);
			return false;
		}
		catch (Exception ex2)
		{
			Log.Error("RestartElevated", ex2);
			return false;
		}
	}

	private static List<string> CollectHiddenTrayExes(List<TrayIconHider.TrayRecord> records)
	{
		HashSet<string> hashSet = new HashSet<string>(StringComparer.OrdinalIgnoreCase);
		foreach (TrayIconHider.TrayRecord record in records)
		{
			if (record.Hidden)
			{
				hashSet.Add(record.Exe);
			}
		}
		return new List<string>(hashSet);
	}

	private void HideShownWindow(IntPtr hwnd)
	{
		if (!_isHidden || _handlingWindowShow) return;
		_handlingWindowShow = true;
		try
		{
			if (WindowHider.HideShown(hwnd, Handle, _selfPid,
				_config.HideProcesses, _hiddenWindows, _hiddenWindowOwners)) _hiddenStateDirty = true;
		}
		finally { _handlingWindowShow = false; }
	}
	private void MaintainHiddenWindows()
	{
		if (!_isHidden) return;
		try
		{
			if (WindowHider.EnforceHidden(Handle, _selfPid,
				_config.HideProcesses, _hiddenWindows, _hiddenWindowOwners) || _hiddenStateDirty)
				{ HiddenStateStore.Save(_hiddenWindows, _hiddenTrayExes); _hiddenStateDirty = false; }
		}
		catch (Exception ex) { Log.Error("MaintainHiddenWindows", ex); }
	}
	// 定时给本程序窗口和名单内目标程序窗口刷新防录屏亲和性（覆盖新开的窗口/对话框）。
	private void ApplyCaptureGuard()
	{
		// 只有按下快捷键进入隐身后才刷新防录屏亲和性。
		if (_config == null || !_config.AntiCapture || !_isHidden) return;
		try
		{
			CaptureGuard.Refresh(_selfPid, Handle, _config.HideProcesses);
		}
		catch (Exception ex) { Log.Error("ApplyCaptureGuard", ex); }
	}
	// 进入隐身时启用防录屏（给本程序和名单内窗口设 WDA_EXCLUDEFROMCAPTURE）。
	private void StartCaptureProtection()
	{
		if (_config == null || !_config.AntiCapture) return;
		try
		{
			CaptureGuard.Enabled = true;
			CaptureGuard.Apply(Handle);
			ApplyCaptureGuard();
			CaptureGuard.StartSelfProtection();
			_captureGuard.Start();
		}
		catch (Exception ex) { Log.Error("StartCaptureProtection", ex); }
	}
	// 退出隐身时关闭防录屏，把窗口恢复为可被截屏/录屏。
	private void StopCaptureProtection()
	{
		try
		{
			_captureGuard.Stop();
			CaptureGuard.Enabled = false;
			CaptureGuard.ClearAll();
		}
		catch (Exception ex) { Log.Error("StopCaptureProtection", ex); }
	}
	// 托盘里切换“防止录屏/截屏”时调用。只改偏好；实际防护在隐身期间才生效。
	private void ApplyCaptureGuardToggle()
	{
		_config.Save();
		if (_config.AntiCapture)
		{
			if (_isHidden) { StartCaptureProtection(); }
			SetStatus("已开启防录屏/截屏（按快捷键隐身后生效）");
		}
		else
		{
			StopCaptureProtection();
			SetStatus("已关闭防录屏/截屏");
		}
	}
	private void RestoreEverything()
	{
		// 先停止持续隐藏，避免恢复的窗口又被隐藏。
		_hideGuard.Stop();
		if (_windowShowWatcher != null) { _windowShowWatcher.Dispose(); _windowShowWatcher = null; }
		if (!_isHidden)
		{
			return;
		}
		try
		{
			Log.Write("=== RestoreEverything begin === count=" + _hiddenWindows.Count);
			// 轻享版特色：恢复时再发一次媒体键，让先前被暂停的音/视频继续播放。
			if (_config.PauseMedia)
			{
				Native.TapMediaPlayPause();                         // 先让支持媒体键的播放器继续
				AudioMute.SetMuted(_config.HideProcesses, false);   // 再解除静音
				Log.Write("PauseMedia -> 解除静音 + 发送媒体继续键");
			}
            try { ModernTray.Restore(); } catch (Exception ex) { Log.Error("ModernTray.Restore", ex); }
			if (_hiddenTrayExes.Count > 0)
			{
				TrayIconHider.Restore(_hiddenTrayExes);
			}
			WindowHider.Restore(_hiddenWindows);
			ShellHider.EnsureTaskbarVisible();
			HiddenStateStore.Clear();
			int count = _hiddenWindows.Count;
			_hiddenWindows.Clear();
			_hiddenWindowOwners.Clear();
			_hiddenTrayExes.Clear();
			_isHidden = false;
			StopCaptureProtection();
			_tray.Visible = true;
			if (_selfWasVisible)
			{
				ShowMainWindow();
			}
			else
			{
				SetStatus("已恢复 " + count + " 个窗口");
			}
			if (_foregroundBefore != IntPtr.Zero && Native.IsWindow(_foregroundBefore))
			{
				Native.SetForegroundWindow(_foregroundBefore);
			}
			Log.Write("restore done, form.Visible=" + ((Control)this).Visible);
		}
		catch (Exception ex)
		{
			Log.Error("RestoreEverything", ex);
		}
	}

	private void ShowTrayBalloon(string text)
	{
		try
		{
			_tray.BalloonTipTitle = "一键隐身·轻享版";
			_tray.BalloonTipText = text;
			_tray.BalloonTipIcon = (ToolTipIcon)1;
			_tray.ShowBalloonTip(6000);
		}
		catch (Exception)
		{
		}
	}

	private void ShowMainWindow()
	{
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Invalid comparison between Unknown and I4
		if (_isHidden)
		{
			RestoreEverything();
		}
		((Control)this).Show();
		if ((int)((Form)this).WindowState == 1)
		{
			((Form)this).WindowState = (FormWindowState)0;
		}
		Native.SetForegroundWindow(((Control)this).Handle);
		SetStatus("状态：待命");
	}

	private void ExitApp()
	{
		_reallyExit = true;
		((Form)this).Close();
	}

	protected override void WndProc(ref Message m)
	{
		try
		{
			if (_hotKeys.HandleMessage(ref m))
			{
				return;
			}
			if (m.Msg == (int)WM_SHOWME)
			{
				Log.Write("recv WM_SHOWME");
				ShowMainWindow();
				return;
			}
		}
		catch (Exception ex)
		{
			Log.Error("WndProc msg=0x" + m.Msg.ToString("X"), ex);
		}
		base.WndProc(ref m);
	}

	protected override void OnHandleDestroyed(EventArgs e)
	{
		_hotKeys.Unregister();
		base.OnHandleDestroyed(e);
	}

	protected override void OnFormClosing(FormClosingEventArgs e)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Invalid comparison between Unknown and I4
		if (!_reallyExit && (int)e.CloseReason == 3)
		{
			((CancelEventArgs)(object)e).Cancel = true;
			((Control)this).Hide();
			if (!_isHidden)
			{
				_tray.Visible = true;
			}
		}
		else
		{
			CleanUp();
			base.OnFormClosing(e);
		}
	}

	private void CleanUp()
	{
		_hideGuard.Stop();
		if (_windowShowWatcher != null) { _windowShowWatcher.Dispose(); _windowShowWatcher = null; }
		_hideGuard.Dispose();
		try
		{
            try { ModernTray.Restore(); } catch (Exception ex) { Log.Error("ModernTray.CleanUp", ex); }
			if (_hiddenTrayExes.Count > 0)
			{
				TrayIconHider.Restore(_hiddenTrayExes);
			}
			if (_isHidden)
			{
				WindowHider.Restore(_hiddenWindows);
			}
			ShellHider.EnsureTaskbarVisible();
			HiddenStateStore.Clear();
			_hotKeys.Dispose();
			_tray.Visible = false;
			((Component)(object)_tray).Dispose();
		}
		catch (Exception)
		{
		}
	}

	private void OnOptionChanged()
	{
		if (!_suppressEvents)
		{
			_config.AutoStart = _chkAutoStart.Checked;
			_config.PauseMedia = _chkPauseMedia.Checked;
			_config.Save();
			_config.ApplyAutoStart();
			SetStatus("设置已保存");
		}
	}

	private void ApplyConfigToUi()
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		_suppressEvents = true;
		((Control)_hotKeyValue).Text = HotKeyManager.Describe(_config.HotKey);
		_chkAutoStart.Checked = _config.AutoStart;
		_chkPauseMedia.Checked = _config.PauseMedia;
		_suppressEvents = false;
		UpdateProgramSummary();
	}

	private void SetStatus(string text)
	{
		((Control)_statusLabel).Text = "状态：" + text;
	}

	private static Icon LoadOwnIcon(bool wantLarge)
	{
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Expected Obj, but got Unknown
		IntPtr[] array = new IntPtr[1];
		IntPtr[] array2 = new IntPtr[1];
		try
		{
			if (ExtractIconEx(Application.ExecutablePath, 0, array2, array, 1u) != 0)
			{
				IntPtr intPtr = (wantLarge ? array2[0] : array[0]);
				if (intPtr == IntPtr.Zero)
				{
					intPtr = (wantLarge ? array[0] : array2[0]);
				}
				if (intPtr != IntPtr.Zero)
				{
					return (Icon)Icon.FromHandle(intPtr).Clone();
				}
			}
		}
		catch (Exception ex)
		{
			Log.Write("读取自身图标失败：" + ex.Message);
		}
		finally
		{
			if (array2[0] != IntPtr.Zero)
			{
				DestroyIcon(array2[0]);
			}
			if (array[0] != IntPtr.Zero)
			{
				DestroyIcon(array[0]);
			}
		}
		return SystemIcons.Application;
	}

	[DllImport("user32.dll", SetLastError = true)]
	private static extern bool DestroyIcon(IntPtr hIcon);

	[DllImport("shell32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
	private static extern uint ExtractIconEx(string file, int index, IntPtr[] large, IntPtr[] small, uint count);
}
internal static class Native
{
	// Windows API 声明及其轻量辅助方法。
	[UnmanagedFunctionPointer(CallingConvention.Winapi)]
	public delegate bool EnumWindowsProc(IntPtr hWnd, IntPtr lParam);

	public struct RECT
	{
		public int Left;

		public int Top;

		public int Right;

		public int Bottom;
	}

	public const int GWL_STYLE = -16;

	public const int GWL_EXSTYLE = -20;

	public const int WS_VISIBLE = 268435456;

	public const int WS_EX_TOOLWINDOW = 128;

	public const int WS_EX_APPWINDOW = 262144;

	public const int SW_HIDE = 0;

	public const int SW_SHOWNOACTIVATE = 4;

	public const int SW_SHOW = 5;

	public const int DWMWA_CLOAKED = 14;

	public const int WM_HOTKEY = 786;

	public const uint MOD_ALT = 1u;

	public const uint MOD_CONTROL = 2u;

	public const uint MOD_SHIFT = 4u;

	public const uint MOD_WIN = 8u;

	public const uint MOD_NOREPEAT = 16384u;

	public static readonly IntPtr HWND_BROADCAST = new IntPtr(65535);

	public const uint TOKEN_QUERY = 8u;

	public const int TokenElevation = 20;

	private static bool? _selfElevated;

	public const uint PROCESS_VM_OPERATION = 8u;

	public const uint PROCESS_VM_READ = 16u;

	public const uint PROCESS_VM_WRITE = 32u;

	public const uint PROCESS_QUERY_LIMITED_INFORMATION = 4096u;

	public const uint MEM_COMMIT = 4096u;

	public const uint MEM_RESERVE = 8192u;

	public const uint MEM_RELEASE = 32768u;

	public const uint PAGE_READWRITE = 4u;

	public const int TB_GETBUTTON = 1047;

	public const int TB_BUTTONCOUNT = 1048;

	public const int TB_HIDEBUTTON = 1028;

	public const byte TBSTATE_HIDDEN = 8;

	public static bool SelfIsElevated
	{
		get
		{
			if (!_selfElevated.HasValue)
			{
				if (Environment.GetEnvironmentVariable("MOYUBOSSKEY_FORCE_NORMAL") == "1")
				{
					_selfElevated = false;
					return false;
				}
				_selfElevated = OpenProcessToken(GetCurrentProcess(), 8u, out var tokenHandle) && GetTokenInformation(tokenHandle, 20, out var tokenInformation, 4u, out var _) && tokenInformation != 0;
				if (tokenHandle != IntPtr.Zero)
				{
					CloseHandle(tokenHandle);
				}
			}
			return _selfElevated.Value;
		}
	}

	[DllImport("user32.dll", SetLastError = true)]
	public static extern bool EnumWindows(EnumWindowsProc lpEnumFunc, IntPtr lParam);

	[DllImport("user32.dll", SetLastError = true)]
	public static extern bool EnumChildWindows(IntPtr hWndParent, EnumWindowsProc lpEnumFunc, IntPtr lParam);

	[DllImport("user32.dll")]
	public static extern bool IsWindowVisible(IntPtr hWnd);

	[DllImport("user32.dll")]
	public static extern bool IsWindow(IntPtr hWnd);

	[DllImport("user32.dll")]
	public static extern bool IsIconic(IntPtr hWnd);

	[DllImport("user32.dll", SetLastError = true)]
	public static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

	[DllImport("user32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
	public static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

	[DllImport("user32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
	public static extern IntPtr FindWindowEx(IntPtr hWndParent, IntPtr hWndChildAfter, string lpszClass, string lpszWindow);

	[DllImport("user32.dll", CharSet = CharSet.Unicode)]
	public static extern int GetWindowText(IntPtr hWnd, StringBuilder lpString, int nMaxCount);

	[DllImport("user32.dll", CharSet = CharSet.Unicode)]
	public static extern int GetWindowTextLength(IntPtr hWnd);

	[DllImport("user32.dll", CharSet = CharSet.Unicode)]
	public static extern int GetClassName(IntPtr hWnd, StringBuilder lpClassName, int nMaxCount);

	[DllImport("user32.dll")]
	public static extern uint GetWindowThreadProcessId(IntPtr hWnd, out uint lpdwProcessId);

	[DllImport("user32.dll")]
	public static extern bool GetWindowRect(IntPtr hWnd, out RECT lpRect);

	[DllImport("user32.dll")]
	public static extern IntPtr GetForegroundWindow();

	[DllImport("user32.dll")]
	public static extern bool SetForegroundWindow(IntPtr hWnd);

	[DllImport("user32.dll")]
	public static extern int GetSystemMetrics(int nIndex);

	[DllImport("user32.dll", CharSet = CharSet.Unicode)]
	public static extern uint RegisterWindowMessage(string lpString);

	[DllImport("user32.dll", SetLastError = true)]
	public static extern bool PostMessage(IntPtr hWnd, uint Msg, IntPtr wParam, IntPtr lParam);

	[DllImport("user32.dll", SetLastError = true)]
	public static extern bool RegisterHotKey(IntPtr hWnd, int id, uint fsModifiers, uint vk);

	[DllImport("user32.dll", SetLastError = true)]
	public static extern bool UnregisterHotKey(IntPtr hWnd, int id);

	// 媒体暂停/播放键：进入隐身时发一下让正在播放的视频/音乐暂停，恢复时再发一下继续播放。
	public const byte VK_MEDIA_PLAY_PAUSE = 0xB3;
	private const uint KEYEVENTF_EXTENDEDKEY = 0x1;
	private const uint KEYEVENTF_KEYUP = 0x2;

	[DllImport("user32.dll", SetLastError = true)]
	private static extern void keybd_event(byte bVk, byte bScan, uint dwFlags, UIntPtr dwExtraInfo);

	public static void TapMediaPlayPause()
	{
		try
		{
			keybd_event(VK_MEDIA_PLAY_PAUSE, 0, KEYEVENTF_EXTENDEDKEY, UIntPtr.Zero);
			keybd_event(VK_MEDIA_PLAY_PAUSE, 0, KEYEVENTF_EXTENDEDKEY | KEYEVENTF_KEYUP, UIntPtr.Zero);
		}
		catch (Exception)
		{
		}
	}

	[DllImport("dwmapi.dll")]
	public static extern int DwmGetWindowAttribute(IntPtr hwnd, int dwAttribute, out int pvAttribute, int cbAttribute);

	public const uint WDA_NONE = 0u;

	public const uint WDA_MONITOR = 1u;

	public const uint WDA_EXCLUDEFROMCAPTURE = 17u;

	[DllImport("user32.dll", SetLastError = true)]
	public static extern bool SetWindowDisplayAffinity(IntPtr hWnd, uint dwAffinity);

	[DllImport("user32.dll", SetLastError = true)]
	public static extern bool GetWindowDisplayAffinity(IntPtr hWnd, out uint pdwAffinity);

	[DllImport("user32.dll", EntryPoint = "GetWindowLong")]
	private static extern int GetWindowLong32(IntPtr hWnd, int nIndex);

	[DllImport("user32.dll", EntryPoint = "GetWindowLongPtr")]
	private static extern IntPtr GetWindowLongPtr64(IntPtr hWnd, int nIndex);

	public static IntPtr GetWindowLongPtr(IntPtr hWnd, int nIndex)
	{
		if (IntPtr.Size == 8)
		{
			return GetWindowLongPtr64(hWnd, nIndex);
		}
		return new IntPtr(GetWindowLong32(hWnd, nIndex));
	}

	public static string TextOf(IntPtr hWnd)
	{
		int windowTextLength = GetWindowTextLength(hWnd);
		if (windowTextLength <= 0)
		{
			return string.Empty;
		}
		StringBuilder stringBuilder = new StringBuilder(windowTextLength + 2);
		GetWindowText(hWnd, stringBuilder, stringBuilder.Capacity);
		return stringBuilder.ToString();
	}

	public static string ClassOf(IntPtr hWnd)
	{
		StringBuilder stringBuilder = new StringBuilder(256);
		if (GetClassName(hWnd, stringBuilder, stringBuilder.Capacity) <= 0)
		{
			return string.Empty;
		}
		return stringBuilder.ToString();
	}

	public static bool IsCloaked(IntPtr hWnd)
	{
		int pvAttribute;
		try
		{
			if (DwmGetWindowAttribute(hWnd, 14, out pvAttribute, 4) != 0)
			{
				return false;
			}
		}
		catch (DllNotFoundException)
		{
			return false;
		}
		catch (EntryPointNotFoundException)
		{
			return false;
		}
		return pvAttribute != 0;
	}

	[DllImport("kernel32.dll")]
	public static extern IntPtr GetCurrentProcess();

	[DllImport("advapi32.dll", SetLastError = true)]
	public static extern bool OpenProcessToken(IntPtr processHandle, uint desiredAccess, out IntPtr tokenHandle);

	[DllImport("advapi32.dll", SetLastError = true)]
	public static extern bool GetTokenInformation(IntPtr tokenHandle, int tokenInformationClass, out uint tokenInformation, uint tokenInformationLength, out uint returnLength);

	public static bool IsProcessElevated(uint pid)
	{
		IntPtr intPtr = OpenProcess(4096u, bInheritHandle: false, pid);
		if (intPtr == IntPtr.Zero)
		{
			return false;
		}
		try
		{
			if (!OpenProcessToken(intPtr, 8u, out var tokenHandle))
			{
				return false;
			}
			try
			{
				if (!GetTokenInformation(tokenHandle, 20, out var tokenInformation, 4u, out var _))
				{
					return false;
				}
				return tokenInformation != 0;
			}
			finally
			{
				CloseHandle(tokenHandle);
			}
		}
		finally
		{
			CloseHandle(intPtr);
		}
	}

	[DllImport("user32.dll")]
	public static extern IntPtr SendMessage(IntPtr hWnd, int msg, IntPtr wParam, IntPtr lParam);

	[DllImport("kernel32.dll", SetLastError = true)]
	public static extern IntPtr OpenProcess(uint dwDesiredAccess, bool bInheritHandle, uint dwProcessId);

	[DllImport("kernel32.dll", SetLastError = true)]
	public static extern bool CloseHandle(IntPtr hObject);

	[DllImport("kernel32.dll", SetLastError = true)]
	public static extern IntPtr VirtualAllocEx(IntPtr hProcess, IntPtr lpAddress, IntPtr dwSize, uint flAllocationType, uint flProtect);

	[DllImport("kernel32.dll", SetLastError = true)]
	public static extern bool VirtualFreeEx(IntPtr hProcess, IntPtr lpAddress, IntPtr dwSize, uint dwFreeType);

	[DllImport("kernel32.dll", SetLastError = true)]
	public static extern bool ReadProcessMemory(IntPtr hProcess, IntPtr lpBaseAddress, byte[] lpBuffer, IntPtr nSize, out IntPtr lpNumberOfBytesRead);
}

// 隐身时对「要隐藏的程序」的音频会话静音（Windows Core Audio / WASAPI）。
// 比发媒体键可靠得多：媒体键只能暂停实现了 Media Session 的播放器（如 YouTube），
// 而普通网页 <video>、广告、很多播放器都不响应；直接静音它们的音频会话则一律生效（含 Chrome）。
internal static class AudioMute
{
	private static readonly Guid CLSID_MMDeviceEnumerator = new Guid("BCDE0395-E52F-467C-8E3D-C4579291692E");
	private static Guid IID_IAudioSessionManager2 = new Guid("77AA99A0-1BD6-484F-8BC7-2C654C9A9B6F");
	private static Guid NoCtx = Guid.Empty;

	[ComImport, Guid("A95664D2-9614-4F35-A746-DE8DB63617E6"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	private interface IMMDeviceEnumerator
	{
		int EnumAudioEndpoints(int dataFlow, int stateMask, out IntPtr devices);
		int GetDefaultAudioEndpoint(int dataFlow, int role, out IMMDevice ppDevice);
	}
	[ComImport, Guid("D666063F-1587-4E43-81F1-B948E807363F"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	private interface IMMDevice
	{
		int Activate(ref Guid iid, int clsCtx, IntPtr activationParams,
			[MarshalAs(UnmanagedType.IUnknown)] out object ppInterface);
	}
	[ComImport, Guid("77AA99A0-1BD6-484F-8BC7-2C654C9A9B6F"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	private interface IAudioSessionManager2
	{
		int NotImpl0();
		int NotImpl1();
		int GetSessionEnumerator(out IAudioSessionEnumerator sessionEnum);
	}
	[ComImport, Guid("E2F5BB11-0570-40CA-ACDD-3AA01277DEE8"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	private interface IAudioSessionEnumerator
	{
		int GetCount(out int sessionCount);
		int GetSession(int index, out IAudioSessionControl2 session);
	}
	[ComImport, Guid("bfb7ff88-7239-4fc9-8fa2-07c950be9c6d"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	private interface IAudioSessionControl2
	{
		int NotImpl0(); int NotImpl1(); int NotImpl2(); int NotImpl3(); int NotImpl4();
		int NotImpl5(); int NotImpl6(); int NotImpl7(); int NotImpl8();          // IAudioSessionControl
		int GetSessionIdentifier(out IntPtr id);
		int GetSessionInstanceIdentifier(out IntPtr id);
		int GetProcessId(out uint pid);
		int IsSystemSoundsSession();
		int SetDuckingPreference(bool optOut);
	}
	[ComImport, Guid("87CE5498-68D6-44E5-9215-6DA47EF883D8"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	private interface ISimpleAudioVolume
	{
		int SetMasterVolume(float level, ref Guid ctx);
		int GetMasterVolume(out float level);
		int SetMute(bool mute, ref Guid ctx);
		int GetMute(out bool mute);
	}

	// 给名单内进程的所有音频会话设 / 解静音。失败一律静默，不影响隐身主流程。
	public static void SetMuted(ICollection<string> exes, bool mute)
	{
		if (exes == null || exes.Count == 0) return;
		HashSet<string> set = new HashSet<string>(StringComparer.OrdinalIgnoreCase);
		foreach (string e in exes) { string n = AppConfig.NormalizeExe(e); if (n.Length > 0) set.Add(n); }
		if (set.Count == 0) return;
		object enumObj = null, mgrObj = null;
		try
		{
			Type t = Type.GetTypeFromCLSID(CLSID_MMDeviceEnumerator);
			if (t == null) return;
			enumObj = Activator.CreateInstance(t);
			IMMDeviceEnumerator devEnum = (IMMDeviceEnumerator)enumObj;
			IMMDevice dev;
			if (devEnum.GetDefaultAudioEndpoint(0 /*eRender*/, 1 /*eMultimedia*/, out dev) != 0 || dev == null) return;
			object o;
			if (dev.Activate(ref IID_IAudioSessionManager2, 23 /*CLSCTX_ALL*/, IntPtr.Zero, out o) != 0 || o == null) return;
			mgrObj = o;
			IAudioSessionManager2 mgr = (IAudioSessionManager2)o;
			IAudioSessionEnumerator sessions;
			if (mgr.GetSessionEnumerator(out sessions) != 0 || sessions == null) return;
			int count;
			if (sessions.GetCount(out count) != 0) return;
			for (int i = 0; i < count; i++)
			{
				IAudioSessionControl2 ctrl;
				if (sessions.GetSession(i, out ctrl) != 0 || ctrl == null) continue;
				try
				{
					uint pid;
					if (ctrl.GetProcessId(out pid) != 0 || pid == 0) continue;
					if (!set.Contains(AppCatalog.ProcessExeOf(pid))) continue;
					ISimpleAudioVolume vol = ctrl as ISimpleAudioVolume;
					if (vol != null) vol.SetMute(mute, ref NoCtx);
				}
				catch (Exception) { }
				finally { Marshal.ReleaseComObject(ctrl); }
			}
			Marshal.ReleaseComObject(sessions);
			Log.Write("AudioMute.SetMuted(" + mute + ") 名单=" + string.Join(",", set) + " 会话数=" + count);
		}
		catch (Exception ex) { Log.Error("AudioMute.SetMuted", ex); }
		finally
		{
			if (mgrObj != null) try { Marshal.ReleaseComObject(mgrObj); } catch { }
			if (enumObj != null) try { Marshal.ReleaseComObject(enumObj); } catch { }
		}
	}
}
internal static class Program
{
	// 程序入口：保证单实例，并在启动时恢复遗留的隐藏状态。
	private const string MutexName = "MoyuBossKeyLite_SingleInstance_v1";

	[STAThread]
	private static void Main(string[] args)
	{
		bool flag = args != null && Array.IndexOf(args, "--hide-now") >= 0;
		Mutex mutex = null;
		int num = (args != null && (Array.IndexOf(args,"--wait-update") >= 0 || Array.IndexOf(args,"--elevated-restart") >= 0) ? 300 : flag ? 50 : 0);
		int num2 = 0;
		while (true)
		{
			mutex = new Mutex(initiallyOwned: true, "MoyuBossKeyLite_SingleInstance_v1", out var createdNew);
			if (createdNew)
			{
				break;
			}
			if (num2 >= num)
			{
				uint num3 = Native.RegisterWindowMessage("MoyuBossKeyLite_ShowMe");
				if (num3 != 0)
				{
					Native.PostMessage(Native.HWND_BROADCAST, num3, IntPtr.Zero, IntPtr.Zero);
				}
				return;
			}
			num2++;
			mutex.Close();
			Thread.Sleep(200);
		}
		using (mutex)
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Log.Clear();
			// 防录屏延后到按快捷键隐身时才启用，进程启动阶段不拦截捕获。
			CaptureGuard.Enabled = false;
			AppDomain.CurrentDomain.UnhandledException += (object s, UnhandledExceptionEventArgs e) =>
			{
				Log.Error("UnhandledException", (e.ExceptionObject as Exception) ?? new Exception(Convert.ToString(e.ExceptionObject)));
			};
			Application.ThreadException += (object s, ThreadExceptionEventArgs e) =>
			{
				Log.Error("ThreadException", e.Exception);
			};
			try
			{
				try { ModernTray.Restore(); } catch (Exception ex) { Log.Error("ModernTray.Recover", ex); }
                HiddenStateStore.RecoverOrphaned();
			}
			catch (Exception ex)
			{
				Log.Error("RecoverOrphaned", ex);
			}
			            using (var main = new MainForm(flag))
            {
                Application.Run(main);
            }
		}
	}
}
internal sealed class ProgramPickerDialog : Form
{
	// 展示可隐藏的运行中程序，并保留已经选择但暂未运行的进程名。
	private const string HintText = "勾选的程序在按老板键时会被隐藏，其余窗口保持原样。按进程名匹配，所以该程序之后新开的窗口也会一起隐藏。";

	private const string EmptyText = "当前没有检测到打开着窗口的程序。把要隐藏的程序打开，再点「刷新」。";

	private static readonly Color TipGray = Color.FromArgb(120, 120, 120);

	private static readonly Color TipWarn = Color.FromArgb(170, 90, 30);

	private static readonly Color TipOk = Color.FromArgb(24, 130, 60);

	private readonly ListView _list = new ListView();

	private readonly ImageList _icons = new ImageList();

	private readonly List<AppInfo> _apps = new List<AppInfo>();

	private readonly HashSet<string> _checked = new HashSet<string>(StringComparer.OrdinalIgnoreCase);

	private readonly Label _tip = new Label();

	private readonly System.Windows.Forms.Timer _statusTimer = new System.Windows.Forms.Timer();

	public List<string> Selected { get; private set; }

	public ProgramPickerDialog(IEnumerable<string> current)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected Obj, but got Unknown
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected Obj, but got Unknown
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected Obj, but got Unknown
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected Obj, but got Unknown
		if (current != null)
		{
			foreach (string item in current)
			{
				_checked.Add(item);
			}
		}
		Selected = new List<string>();
		BuildUi();
		LoadApps();
	}

	private void BuildUi()
	{
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Expected Obj, but got Unknown
		((Control)this).Text = "选择要隐藏的程序";
		((Control)this).Font = new Font("Microsoft YaHei UI", 9f);
		((Form)this).FormBorderStyle = (FormBorderStyle)3;
		((Form)this).MaximizeBox = false;
		((Form)this).MinimizeBox = false;
		((Form)this).ShowInTaskbar = false;
		((Form)this).StartPosition = (FormStartPosition)4;
		((Form)this).ClientSize = new Size(486, 424);
		((Control)this).BackColor = Color.White;
		((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
		((Control)_tip).Text = "勾选的程序在按老板键时会被隐藏，其余窗口保持原样。按进程名匹配，所以该程序之后新开的窗口也会一起隐藏。";
		((Control)_tip).ForeColor = TipGray;
		((Control)_tip).Bounds = new Rectangle(16, 10, 454, 34);
		((Control)this).Controls.Add((Control)(object)_tip);
		_statusTimer.Interval = 2600;
		_statusTimer.Tick += delegate
		{
			_statusTimer.Stop();
			RestoreTip();
		};
		_icons.ImageSize = new Size(20, 20);
		_icons.ColorDepth = (ColorDepth)32;
		((Control)_list).Bounds = new Rectangle(16, 50, 454, 322);
		_list.View = (View)1;
		_list.CheckBoxes = true;
		_list.FullRowSelect = true;
		_list.MultiSelect = false;
		_list.HideSelection = false;
		_list.HeaderStyle = (ColumnHeaderStyle)1;
		_list.SmallImageList = _icons;
		_list.Columns.Add("程序", 294);
		_list.Columns.Add("进程", 138);
		((Control)this).Controls.Add((Control)(object)_list);
		((Control)this).Controls.Add((Control)(object)MakeButton("全选", 16, 384, 72, delegate
		{
			SetAll(value: true);
		}));
		((Control)this).Controls.Add((Control)(object)MakeButton("清空", 94, 384, 72, delegate
		{
			SetAll(value: false);
		}));
		((Control)this).Controls.Add((Control)(object)MakeButton("刷新", 176, 384, 72, delegate
		{
			RefreshApps();
		}));
		Button val = MakeButton("确定", 328, 384, 68, delegate
		{
			OnOk();
		});
		((Control)val).BackColor = Color.FromArgb(204, 58, 46);
		((Control)val).ForeColor = Color.White;
		((ButtonBase)val).FlatAppearance.BorderColor = Color.FromArgb(204, 58, 46);
		((Control)this).Controls.Add((Control)(object)val);
		Button val2 = MakeButton("取消", 404, 384, 66, delegate
		{
			((Form)this).DialogResult = (DialogResult)2;
			((Form)this).Close();
		});
		((Control)this).Controls.Add((Control)(object)val2);
		((Form)this).AcceptButton = (IButtonControl)(object)val;
		((Form)this).CancelButton = (IButtonControl)(object)val2;
	}

	private static Button MakeButton(string text, int x, int y, int width, EventHandler onClick)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Expected Obj, but got Unknown
		Button val = new Button
		{
			Text = text,
			Bounds = new Rectangle(x, y, width, 28),
			FlatStyle = (FlatStyle)0
		};
		((ButtonBase)val).FlatAppearance.BorderSize = 1;
		((ButtonBase)val).FlatAppearance.BorderColor = Color.FromArgb(205, 205, 205);
		((ButtonBase)val).UseVisualStyleBackColor = false;
		((Control)val).BackColor = Color.White;
		((Control)val).ForeColor = Color.FromArgb(60, 60, 60);
		((Control)val).Cursor = Cursors.Hand;
		((Control)val).Click += onClick;
		return val;
	}

	private void LoadApps()
	{
		// 重新枚举窗口并刷新列表，同时恢复已有勾选状态。
		_list.BeginUpdate();
		try
		{
			_list.Items.Clear();
			_list.SmallImageList = null;
			_icons.Images.Clear();
			foreach (AppInfo app in _apps)
			{
				try
				{
					app.Dispose();
				}
				catch (Exception)
				{
				}
			}
			_apps.Clear();
			_list.SmallImageList = _icons;
			uint id = (uint)Process.GetCurrentProcess().Id;
			List<AppInfo> list = AppCatalog.EnumerateRunning(IntPtr.Zero, id);
			HashSet<string> hashSet = new HashSet<string>(StringComparer.OrdinalIgnoreCase);
			foreach (AppInfo item in list)
			{
				hashSet.Add(item.Exe);
				AddRow(item);
			}
			List<string> list2 = new List<string>();
			foreach (string item2 in _checked)
			{
				if (!hashSet.Contains(item2))
				{
					list2.Add(item2);
				}
			}
			list2.Sort(StringComparer.OrdinalIgnoreCase);
			foreach (string item3 in list2)
			{
				AppInfo appInfo = new AppInfo();
				appInfo.Exe = item3;
				appInfo.Title = "未在运行";
				appInfo.Running = false;
				AddRow(appInfo);
			}
		}
		finally
		{
			_list.EndUpdate();
		}
		RestoreTip();
	}

	private void RefreshApps()
	{
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Expected Obj, but got Unknown
		//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d8: Expected Obj, but got Unknown
		_checked.Clear();
		foreach (ListViewItem item in _list.Items)
		{
			ListViewItem val = item;
			if (val.Tag is AppInfo appInfo && val.Checked)
			{
				_checked.Add(appInfo.Exe);
			}
		}
		string text = null;
		if (_list.SelectedItems.Count > 0 && _list.SelectedItems[0].Tag is AppInfo appInfo2)
		{
			text = appInfo2.Exe;
		}
		LoadApps();
		if (text != null)
		{
			foreach (ListViewItem item2 in _list.Items)
			{
				ListViewItem val2 = item2;
				if (val2.Tag is AppInfo appInfo3 && string.Equals(appInfo3.Exe, text, StringComparison.OrdinalIgnoreCase))
				{
					val2.Selected = true;
					val2.EnsureVisible();
					break;
				}
			}
		}
		if (_list.Items.Count == 0)
		{
			RestoreTip();
		}
		else
		{
			ShowStatus("已刷新，共 " + _list.Items.Count + " 个程序。");
		}
	}

	private void RestoreTip()
	{
		if (_list.Items.Count == 0)
		{
			SetTip("当前没有检测到打开着窗口的程序。把要隐藏的程序打开，再点「刷新」。", TipWarn);
		}
		else
		{
			SetTip("勾选的程序在按老板键时会被隐藏，其余窗口保持原样。按进程名匹配，所以该程序之后新开的窗口也会一起隐藏。", TipGray);
		}
	}

	private void ShowStatus(string text)
	{
		SetTip(text, TipOk);
		_statusTimer.Stop();
		_statusTimer.Start();
	}

	private void SetTip(string text, Color color)
	{
		((Control)_tip).Text = text;
		((Control)_tip).ForeColor = color;
	}

	private void AddRow(AppInfo app)
	{
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Expected Obj, but got Unknown
		string text;
		if (app.Running)
		{
			text = ((app.WindowCount <= 1) ? app.Exe : (app.Exe + "（" + app.WindowCount + " 个窗口）"));
		}
		else
		{
			text = app.Exe + "（未运行）";
		}
		ListViewItem val = new ListViewItem(app.DisplayName);
		val.SubItems.Add(text);
		val.Tag = app;
		try
		{
			_icons.Images.Add(app.Icon);
			val.ImageIndex = _icons.Images.Count - 1;
		}
		catch (Exception)
		{
			val.ImageIndex = -1;
		}
		_apps.Add(app);
		_list.Items.Add(val);
		val.Checked = _checked.Contains(app.Exe);
	}

	private void SetAll(bool value)
	{
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		foreach (ListViewItem item in _list.Items)
		{
			item.Checked = value;
		}
	}

	private void OnOk()
	{
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Expected Obj, but got Unknown
		Selected.Clear();
		foreach (ListViewItem item in _list.Items)
		{
			ListViewItem val = item;
			if (val.Checked && val.Tag is AppInfo appInfo)
			{
				string text = AppConfig.NormalizeExe(appInfo.Exe);
				if (text.Length > 0 && !Selected.Contains(text))
				{
					Selected.Add(text);
				}
			}
		}
		((Form)this).DialogResult = (DialogResult)1;
		((Form)this).Close();
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing)
		{
			try
			{
				_statusTimer.Stop();
				((Component)(object)_statusTimer).Dispose();
			}
			catch (Exception)
			{
			}
			try
			{
				_list.SmallImageList = null;
			}
			catch (Exception)
			{
			}
			try
			{
				((Component)(object)_icons).Dispose();
			}
			catch (Exception)
			{
			}
			foreach (AppInfo app in _apps)
			{
				try
				{
					app.Dispose();
				}
				catch (Exception)
				{
				}
			}
		}
		base.Dispose(disposing);
	}
}
internal static class ShellHider
{
	// 确保主任务栏和多显示器任务栏不会被隐藏。
	public static int EnsureTaskbarVisible()
	{
		int fixedCount = 0;
		if (ForceShow(Native.FindWindow("Shell_TrayWnd", null)))
		{
			fixedCount++;
		}
		Native.EnumWindows((IntPtr hWnd, IntPtr lParam) =>
		{
			if (string.Equals(Native.ClassOf(hWnd), "Shell_SecondaryTrayWnd", StringComparison.OrdinalIgnoreCase) && ForceShow(hWnd))
			{
				fixedCount++;
			}
			return true;
		}, IntPtr.Zero);
		if (fixedCount > 0)
		{
			Log.Write("ShellHider.EnsureTaskbarVisible -> 拉回 " + fixedCount + " 条任务栏");
		}
		return fixedCount;
	}

	public static bool IsTaskbarVisible()
	{
		IntPtr intPtr = Native.FindWindow("Shell_TrayWnd", null);
		if (intPtr != IntPtr.Zero)
		{
			return Native.IsWindowVisible(intPtr);
		}
		return false;
	}

	private static bool ForceShow(IntPtr hWnd)
	{
		if (hWnd == IntPtr.Zero)
		{
			return false;
		}
		if (!Native.IsWindow(hWnd))
		{
			return false;
		}
		if (Native.IsWindowVisible(hWnd))
		{
			return false;
		}
		Native.ShowWindow(hWnd, 4);
		return Native.IsWindowVisible(hWnd);
	}
}
internal static class TrayIconHider
{
	// 通过 Explorer 的工具栏消息隐藏和恢复目标程序的通知区图标。
	internal sealed class TrayRecord
	{
		public string Exe = string.Empty;

		public int CmdId;

		public bool Hidden;
	}

	private sealed class TrayButton
	{
		public int CmdId;

		public byte FsState;

		public IntPtr OwnerHwnd;

		public uint OwnerPid;

		public string Exe = string.Empty;

		public bool Hidden => (FsState & 8) != 0;
	}

	[System.Reflection.Obfuscation(Exclude=true, ApplyToMembers=true)]
    private struct TBBUTTON
	{
		public int iBitmap;

		public int idCommand;

		public byte fsState;

		public byte fsStyle;

		public IntPtr dwData;

		public IntPtr iString;
	}

	private sealed class ProcessMemory : IDisposable
	{
		private IntPtr _process;

		private IntPtr _buffer;

		public static ProcessMemory OpenFor(IntPtr window)
		{
			Native.GetWindowThreadProcessId(window, out var lpdwProcessId);
			if (lpdwProcessId == 0)
			{
				return null;
			}
			IntPtr intPtr = Native.OpenProcess(4152u, bInheritHandle: false, lpdwProcessId);
			if (intPtr == IntPtr.Zero)
			{
				Log.Write("  OpenProcess 失败 pid=" + lpdwProcessId + " err=" + Marshal.GetLastWin32Error());
				return null;
			}
			IntPtr intPtr2 = Native.VirtualAllocEx(intPtr, IntPtr.Zero, new IntPtr(4096), 12288u, 4u);
			if (intPtr2 == IntPtr.Zero)
			{
				Native.CloseHandle(intPtr);
				Log.Write("  VirtualAllocEx 失败 pid=" + lpdwProcessId + " err=" + Marshal.GetLastWin32Error());
				return null;
			}
			return new ProcessMemory
			{
				_process = intPtr,
				_buffer = intPtr2
			};
		}

		public List<TrayButton> ReadButtons(IntPtr toolbar)
		{
			List<TrayButton> list = new List<TrayButton>();
			int num = (int)Native.SendMessage(toolbar, 1048, IntPtr.Zero, IntPtr.Zero);
			if (num <= 0)
			{
				return list;
			}
			int num2 = Marshal.SizeOf(typeof(TBBUTTON));
			byte[] array = new byte[num2];
			for (int i = 0; i < num; i++)
			{
				Native.SendMessage(toolbar, 1047, new IntPtr(i), _buffer);
				if (!Native.ReadProcessMemory(_process, _buffer, array, new IntPtr(num2), out var lpNumberOfBytesRead))
				{
					continue;
				}
				TrayButton trayButton = new TrayButton();
				trayButton.CmdId = BitConverter.ToInt32(array, OffCmdId);
				trayButton.FsState = array[OffFsState];
				IntPtr intPtr = ReadPointer(array, OffDwData);
				if (intPtr == IntPtr.Zero)
				{
					continue;
				}
				byte[] array2 = new byte[IntPtr.Size];
				if (!Native.ReadProcessMemory(_process, intPtr, array2, new IntPtr(IntPtr.Size), out lpNumberOfBytesRead))
				{
					continue;
				}
				IntPtr intPtr2 = ReadPointer(array2, 0);
				if (!(intPtr2 == IntPtr.Zero))
				{
					Native.GetWindowThreadProcessId(intPtr2, out var lpdwProcessId);
					if (lpdwProcessId != 0)
					{
						trayButton.OwnerHwnd = intPtr2;
						trayButton.OwnerPid = lpdwProcessId;
						trayButton.Exe = AppCatalog.ProcessExeOf(lpdwProcessId);
						list.Add(trayButton);
					}
				}
			}
			return list;
		}

		public void SendCommand(IntPtr toolbar, int msg, int cmdId, int flag)
		{
			Native.SendMessage(toolbar, msg, new IntPtr(cmdId), new IntPtr(flag));
		}

		public bool IsHiddenNow(IntPtr toolbar, int cmdId)
		{
			foreach (TrayButton item in ReadButtons(toolbar))
			{
				if (item.CmdId == cmdId)
				{
					return item.Hidden;
				}
			}
			return false;
		}

		private static IntPtr ReadPointer(byte[] buf, int offset)
		{
			if (IntPtr.Size != 8)
			{
				return new IntPtr(BitConverter.ToInt32(buf, offset));
			}
			return new IntPtr(BitConverter.ToInt64(buf, offset));
		}

		public void Dispose()
		{
			if (_buffer != IntPtr.Zero)
			{
				Native.VirtualFreeEx(_process, _buffer, IntPtr.Zero, 32768u);
				_buffer = IntPtr.Zero;
			}
			if (_process != IntPtr.Zero)
			{
				Native.CloseHandle(_process);
				_process = IntPtr.Zero;
			}
		}
	}

	private static readonly int OffCmdId = Marshal.OffsetOf(typeof(TBBUTTON), "idCommand").ToInt32();

	private static readonly int OffFsState = Marshal.OffsetOf(typeof(TBBUTTON), "fsState").ToInt32();

	private static readonly int OffDwData = Marshal.OffsetOf(typeof(TBBUTTON), "dwData").ToInt32();

	public static List<TrayRecord> Hide(ICollection<string> processFilter)
	{
		// 遍历所有任务栏工具栏，只处理名单中的进程。
		List<TrayRecord> list = new List<TrayRecord>();
		if (processFilter == null || processFilter.Count == 0)
		{
			return list;
		}
		HashSet<string> filter = new HashSet<string>(processFilter, StringComparer.OrdinalIgnoreCase);
            try
            {
                foreach (var icon in ModernTray.Hide(processFilter))
                    list.Add(new TrayRecord { Exe = icon.Exe, Hidden = true });
            }
            catch (Exception ex) { Log.Error("ModernTray.Hide", ex); }
		foreach (IntPtr item in EnumTrayToolbars())
		{
			try
			{
				HideOnToolbar(item, filter, list);
			}
			catch (Exception ex)
			{
				Log.Error("TrayIconHider.Hide toolbar=0x" + ((long)item).ToString("X"), ex);
			}
		}
		int num = 0;
		foreach (TrayRecord item2 in list)
		{
			if (item2.Hidden)
			{
				num++;
			}
		}
		Log.Write("TrayIconHider.Hide -> " + num + " 个托盘图标已隐藏（命中 " + list.Count + "）");
		return list;
	}

	public static int Restore(ICollection<string> exes)
	{
		// 根据保存的进程名恢复此前隐藏的托盘按钮。
		if (exes == null || exes.Count == 0)
		{
			return 0;
		}
		HashSet<string> hashSet = new HashSet<string>(exes, StringComparer.OrdinalIgnoreCase);
		int num = 0;
		foreach (IntPtr item in EnumTrayToolbars())
		{
			try
			{
				using ProcessMemory processMemory = ProcessMemory.OpenFor(item);
				if (processMemory == null)
				{
					continue;
				}
				foreach (TrayButton item2 in processMemory.ReadButtons(item))
				{
					if (item2.Hidden && hashSet.Contains(item2.Exe))
					{
						processMemory.SendCommand(item, 1028, item2.CmdId, 0);
						if (!processMemory.IsHiddenNow(item, item2.CmdId))
						{
							num++;
							Log.Write("  托盘图标已恢复 exe=" + item2.Exe + " cmdId=" + item2.CmdId);
						}
					}
				}
			}
			catch (Exception ex)
			{
				Log.Error("TrayIconHider.Restore toolbar=0x" + ((long)item).ToString("X"), ex);
			}
		}
		Log.Write("TrayIconHider.Restore -> " + num + " 个托盘图标已恢复");
		return num;
	}

	private static void HideOnToolbar(IntPtr toolbar, HashSet<string> filter, List<TrayRecord> records)
	{
		using ProcessMemory processMemory = ProcessMemory.OpenFor(toolbar);
		if (processMemory == null)
		{
			return;
		}
		foreach (TrayButton item in processMemory.ReadButtons(toolbar))
		{
			if (item.Exe.Length == 0 || !filter.Contains(item.Exe))
			{
				continue;
			}
			TrayRecord trayRecord = new TrayRecord();
			trayRecord.Exe = item.Exe;
			trayRecord.CmdId = item.CmdId;
			if (item.Hidden)
			{
				trayRecord.Hidden = true;
			}
			else
			{
				processMemory.SendCommand(toolbar, 1028, item.CmdId, 1);
				trayRecord.Hidden = processMemory.IsHiddenNow(toolbar, item.CmdId);
				if (!trayRecord.Hidden)
				{
					Log.Write("  !! TB_HIDEBUTTON 未生效，图标仍在 exe=" + item.Exe + " cmdId=" + item.CmdId);
				}
			}
			records.Add(trayRecord);
		}
	}

	private static List<IntPtr> EnumTrayToolbars()
	{
		List<IntPtr> list = new List<IntPtr>();
		AddToolbarUnder(list, Native.FindWindow("Shell_TrayWnd", null));
		Native.EnumWindows((IntPtr hWnd, IntPtr lParam) =>
		{
			if (string.Equals(Native.ClassOf(hWnd), "Shell_SecondaryTrayWnd", StringComparison.OrdinalIgnoreCase))
			{
				AddToolbarUnder(list, hWnd);
			}
			return true;
		}, IntPtr.Zero);
		IntPtr intPtr = Native.FindWindow("NotifyIconOverflowWindow", null);
		if (intPtr != IntPtr.Zero)
		{
			IntPtr intPtr2 = Native.FindWindowEx(intPtr, IntPtr.Zero, "ToolbarWindow32", null);
			if (intPtr2 != IntPtr.Zero && !list.Contains(intPtr2))
			{
				list.Add(intPtr2);
			}
		}
		return list;
	}

	private static void AddToolbarUnder(List<IntPtr> list, IntPtr trayRoot)
	{
		if (!(trayRoot == IntPtr.Zero))
		{
			IntPtr intPtr = Native.FindWindowEx(trayRoot, IntPtr.Zero, "TrayNotifyWnd", null);
			IntPtr hWndParent = ((intPtr != IntPtr.Zero) ? intPtr : trayRoot);
			IntPtr intPtr2 = IntPtr.Zero;
			IntPtr intPtr3 = Native.FindWindowEx(hWndParent, IntPtr.Zero, "SysPager", null);
			if (intPtr3 != IntPtr.Zero)
			{
				intPtr2 = Native.FindWindowEx(intPtr3, IntPtr.Zero, "ToolbarWindow32", null);
			}
			if (intPtr2 == IntPtr.Zero)
			{
				intPtr2 = Native.FindWindowEx(hWndParent, IntPtr.Zero, "ToolbarWindow32", null);
			}
			if (intPtr2 != IntPtr.Zero && !list.Contains(intPtr2))
			{
				list.Add(intPtr2);
			}
		}
	}
}
internal static class CaptureGuard
{
	// 防录屏/防截屏：给窗口设置显示亲和性。
	// WDA_EXCLUDEFROMCAPTURE(17)：Win10 2004+ 下窗口对截图/录屏完全隐形，用户自己仍能正常看到。
	// 旧系统回退 WDA_MONITOR(1)：录屏里显示为黑块。
	// 对本进程窗口必定成功；对外部程序窗口需要同等或更低完整性级别——建议以管理员身份运行。
	internal static bool Enabled = true;

	// 直接首选 WDA_EXCLUDEFROMCAPTURE(17)。不用 Environment.OSVersion 判断系统版本——
	// 本 exe 未内嵌 Win10 兼容清单时 OSVersion 会谎报成 6.2，导致误判。
	// 真正不支持 17 的老系统，Apply 里会自动回退到 WDA_MONITOR(1)。
	private static readonly uint _desired = Native.WDA_EXCLUDEFROMCAPTURE;

	private static readonly HashSet<IntPtr> _applied = new HashSet<IntPtr>();

	private static readonly object _sync = new object();

	private static void Mark(IntPtr hwnd) { lock (_sync) { _applied.Add(hwnd); } }

	internal static bool Apply(IntPtr hwnd)
	{
		if (!Enabled || hwnd == IntPtr.Zero) return false;
		try
		{
			uint current;
			if (Native.GetWindowDisplayAffinity(hwnd, out current) && current == _desired) { Mark(hwnd); return true; }
			if (Native.SetWindowDisplayAffinity(hwnd, _desired)) { Mark(hwnd); return true; }
			if (_desired == Native.WDA_EXCLUDEFROMCAPTURE && Native.SetWindowDisplayAffinity(hwnd, Native.WDA_MONITOR)) { Mark(hwnd); return true; }
		}
		catch (Exception ex) { Log.Error("CaptureGuard.Apply", ex); }
		return false;
	}

	// 尽早保护：后台线程持续给本进程所有窗口（含启动阶段的激活框等）设防录屏，不依赖主窗口。
	internal static void StartSelfProtection()
	{
		if (!Enabled) return;
		try
		{
			Thread t = new Thread(() =>
			{
				uint self = (uint)Process.GetCurrentProcess().Id;
				while (Enabled)
				{
					try { Refresh(self, IntPtr.Zero, null); } catch (Exception) { }
					Thread.Sleep(1500);
				}
			});
			t.IsBackground = true;
			t.Start();
		}
		catch (Exception) { }
	}

	// 一次 EnumWindows 同时覆盖本进程窗口和名单内目标程序的窗口。
	internal static void Refresh(uint selfPid, IntPtr selfHandle, ICollection<string> filter)
	{
		if (!Enabled) return;
		HashSet<string> selected = (filter != null && filter.Count > 0)
			? new HashSet<string>(filter, StringComparer.OrdinalIgnoreCase) : null;
		try
		{
			Native.EnumWindows((IntPtr h, IntPtr l) =>
			{
				uint pid;
				Native.GetWindowThreadProcessId(h, out pid);
				if (pid == 0) return true;
				if (pid == selfPid) { if (ShouldProtect(h)) Apply(h); return true; }
				if (h == selfHandle) return true;
				if (selected != null && selected.Contains(AppCatalog.ProcessExeOf(pid)) && ShouldProtect(h)) Apply(h);
				return true;
			}, IntPtr.Zero);
		}
		catch (Exception ex) { Log.Error("CaptureGuard.Refresh", ex); }
	}

	// 只给真正可见的普通窗口设防录屏。给隐藏的辅助窗口（输入法窗口、消息窗口、1x1 占位窗口）
	// 或任何分层浮层(工具提示/下拉菜单阴影等)设 WDA_EXCLUDEFROMCAPTURE，会让 DWM 把它们画成屏幕上的一块白框。
	private const int WS_EX_TRANSPARENT = 0x20;
	private const int WS_EX_LAYERED = 0x80000;
	private const int WS_EX_NOREDIRECTIONBITMAP = 0x200000;
	private static readonly HashSet<string> _skipClasses = new HashSet<string>(StringComparer.OrdinalIgnoreCase)
	{
		"IME", "MSCTFIME UI", "Default IME", ".NET-BroadcastEventWindow", "ThumbnailDeviceHelperWnd",
	};

	private static bool ShouldProtect(IntPtr h)
	{
		try
		{
			if (!Native.IsWindowVisible(h)) return false;
			Native.RECT r;
			if (!Native.GetWindowRect(h, out r) || r.Right - r.Left < 4 || r.Bottom - r.Top < 4) return false;
			long ex = Native.GetWindowLongPtr(h, -20).ToInt64();   // GWL_EXSTYLE
			if ((ex & WS_EX_NOREDIRECTIONBITMAP) != 0) return false;
			if ((ex & WS_EX_LAYERED) != 0) return false;   // 分层窗口(工具提示/菜单阴影)设亲和性会被 DWM 画成白框
			StringBuilder cls = new StringBuilder(128);
			Native.GetClassName(h, cls, cls.Capacity);
			string c = cls.ToString();
			if (_skipClasses.Contains(c)) return false;
			return true;
		}
		catch (Exception) { return false; }
	}

	// 关闭防录屏时，把之前设过亲和性的窗口恢复为可录制。
	internal static void ClearAll()
	{
		List<IntPtr> snapshot;
		lock (_sync) { snapshot = new List<IntPtr>(_applied); _applied.Clear(); }
		foreach (IntPtr h in snapshot)
		{
			try { if (Native.IsWindow(h)) Native.SetWindowDisplayAffinity(h, Native.WDA_NONE); }
			catch (Exception) { }
		}
	}
}
internal sealed class WindowShowWatcher : IDisposable
{
 private delegate void WinEventProc(IntPtr hook, uint eventType, IntPtr hwnd,
  int objectId, int childId, uint eventThread, uint eventTime);
 [DllImport("user32.dll", SetLastError = true)]
 private static extern IntPtr SetWinEventHook(uint eventMin, uint eventMax, IntPtr module,
  WinEventProc callback, uint processId, uint threadId, uint flags);
 [DllImport("user32.dll")] private static extern bool UnhookWinEvent(IntPtr hook);
 [DllImport("user32.dll")] private static extern IntPtr GetAncestor(IntPtr hwnd, uint flags);
 private readonly WinEventProc _callback;
 private readonly Action<IntPtr> _onShow;
 private IntPtr _hook;
 private IntPtr _hook2;
 private bool _disposed;
 public WindowShowWatcher(Action<IntPtr> onShow)
 {
  _onShow = onShow;
  _callback = OnEvent;
  // OUTOFCONTEXT: callbacks arrive on the installing UI thread's message loop.
  // 0x8002 EVENT_OBJECT_SHOW（窗口显示）、0x0003 EVENT_SYSTEM_FOREGROUND（切到前台）、
  // 0x0017 EVENT_SYSTEM_MINIMIZEEND（从最小化还原）——三类事件都会让目标窗口重新冒头，
  // 收到即刻回隐，比单纯靠 150ms 轮询更快，尽量不让窗口闪出来。
  _hook = SetWinEventHook(0x8002, 0x8002, IntPtr.Zero, _callback, 0, 0, 0);
  _hook2 = SetWinEventHook(0x0003, 0x0017, IntPtr.Zero, _callback, 0, 0, 0);
  if (_hook == IntPtr.Zero && _hook2 == IntPtr.Zero) throw new Win32Exception(Marshal.GetLastWin32Error());
 }
 private void OnEvent(IntPtr hook, uint eventType, IntPtr hwnd, int objectId,
  int childId, uint eventThread, uint eventTime)
 {
  if (_disposed || hwnd == IntPtr.Zero || objectId != 0 || childId != 0) return;
  if (eventType != 0x8002 && eventType != 0x0003 && eventType != 0x0017) return;
  if (GetAncestor(hwnd, 2) != hwnd) return;
  try { _onShow(hwnd); }
  catch (Exception ex) { Log.Error("WindowShowWatcher", ex); }
 }
 public void Dispose()
 {
  _disposed = true;
  if (_hook != IntPtr.Zero) { UnhookWinEvent(_hook); _hook = IntPtr.Zero; }
  if (_hook2 != IntPtr.Zero) { UnhookWinEvent(_hook2); _hook2 = IntPtr.Zero; }
  GC.KeepAlive(_callback);
 }
}
internal static class WindowHider
{
	// 负责筛选、隐藏和恢复顶层窗口。
	internal sealed class HideTarget
	{
		public IntPtr Hwnd;

		public string Exe;

		public uint Pid;

		public HideTarget(IntPtr hwnd, string exe, uint pid)
		{
			Hwnd = hwnd;
			Exe = exe;
			Pid = pid;
		}
	}

	internal static readonly HashSet<string> ShellClasses = new HashSet<string>(StringComparer.OrdinalIgnoreCase)
	{
		"Progman", "WorkerW", "Shell_TrayWnd", "Shell_SecondaryTrayWnd", "Shell_InputSwitchTopLevelWindow", "TaskListThumbnailWnd", "TaskListOverlayWnd", "ForegroundStaging", "DV2ControlHost", "MsgrIMEWindowClass",
		"SysShadow", "Windows.UI.Core.CoreWindow"
	};

	internal static bool IsHideCandidate(IntPtr hWnd, IntPtr selfHandle, uint selfPid, out uint pid, out string reason)
	{
		pid = 0u;
		reason = null;
		if (!Native.IsWindowVisible(hWnd))
		{
			reason = "invisible";
			return false;
		}
		string item = Native.ClassOf(hWnd);
		Native.GetWindowThreadProcessId(hWnd, out pid);
		if (hWnd == selfHandle)
		{
			reason = "self hwnd";
			return false;
		}
		if (pid == selfPid)
		{
			reason = "self process";
			return false;
		}
		if (ShellClasses.Contains(item))
		{
			reason = "shell class";
			return false;
		}
		if (Native.IsCloaked(hWnd))
		{
			reason = "cloaked";
			return false;
		}
		// 已选程序的工具窗口和无标题悬浮窗也需要一起隐藏和恢复。
		return true;
	}

	public static List<HideTarget> CollectTargets(IntPtr selfHandle, uint selfPid, ICollection<string> processFilter, out List<string> elevatedExes)
	{
		// 先按窗口特征和进程名单筛选，再检测目标进程是否需要管理员权限。
		List<HideTarget> result = new List<HideTarget>();
		elevatedExes = new List<string>();
		if (processFilter == null || processFilter.Count <= 0)
		{
			Log.Write("CollectTargets -> 0 (名单为空，本次不隐藏任何窗口)");
			return result;
		}
		Dictionary<string, List<uint>> pidsOfExe = new Dictionary<string, List<uint>>(StringComparer.OrdinalIgnoreCase);
		Native.EnumWindows((IntPtr hWnd, IntPtr lParam) =>
		{
			if (!IsHideCandidate(hWnd, selfHandle, selfPid, out var pid, out var _))
			{
				return true;
			}
			string text = AppCatalog.ProcessExeOf(pid);
			if (!processFilter.Contains(text))
			{
				Log.Write($"SKIP(not listed {text})  hwnd=0x{(long)hWnd:X}");
				return true;
			}
			Log.Write(string.Format("HIDE(target {0})  hwnd=0x{1:X} pid={2} title={3}", new object[4]
			{
				text,
				(long)hWnd,
				pid,
				Native.TextOf(hWnd)
			}));
			result.Add(new HideTarget(hWnd, text, pid));
			if (!pidsOfExe.TryGetValue(text, out var value))
			{
				value = new List<uint>();
				pidsOfExe[text] = value;
			}
			if (!value.Contains(pid))
			{
				value.Add(pid);
			}
			return true;
		}, IntPtr.Zero);
		if (!Native.SelfIsElevated)
		{
			foreach (KeyValuePair<string, List<uint>> item in pidsOfExe)
			{
				foreach (uint item2 in item.Value)
				{
					if (Native.IsProcessElevated(item2))
					{
						elevatedExes.Add(item.Key);
						break;
					}
				}
			}
			elevatedExes.Sort(StringComparer.CurrentCulture);
		}
		Log.Write("CollectTargets -> " + result.Count + " (按名单过滤), 提权程序 " + elevatedExes.Count + " 个");
		return result;
	}

	private static bool CoversMostOfScreen(IntPtr hWnd)
	{
		if (!Native.GetWindowRect(hWnd, out var lpRect))
		{
			return false;
		}
		int systemMetrics = Native.GetSystemMetrics(76);
		int systemMetrics2 = Native.GetSystemMetrics(77);
		int systemMetrics3 = Native.GetSystemMetrics(78);
		int systemMetrics4 = Native.GetSystemMetrics(79);
		if (systemMetrics3 <= 0 || systemMetrics4 <= 0)
		{
			return false;
		}
		long num = (long)systemMetrics3 * (long)systemMetrics4;
		long num2 = Math.Max(0, lpRect.Right - lpRect.Left);
		long num3 = Math.Max(0, lpRect.Bottom - lpRect.Top);
		if (num2 * num3 * 100 < num * 80)
		{
			return false;
		}
		if (lpRect.Left <= systemMetrics + 8)
		{
			return lpRect.Top <= systemMetrics2 + 8;
		}
		return false;
	}

	public static List<IntPtr> Hide(List<HideTarget> targets, out List<HideTarget> failed)
	{
		// 使用 SW_HIDE 隐藏窗口，并记录被权限隔离阻止的目标。
		List<IntPtr> list = new List<IntPtr>();
		failed = new List<HideTarget>();
		foreach (HideTarget target in targets)
		{
			if (Native.IsWindow(target.Hwnd) && Native.IsWindowVisible(target.Hwnd))
			{
				Native.ShowWindow(target.Hwnd, 0);
				if (!Native.IsWindowVisible(target.Hwnd))
				{
					list.Add(target.Hwnd);
				}
				else
				{
					failed.Add(target);
				}
			}
		}
		if (failed.Count > 0)
		{
			foreach (HideTarget item in failed)
			{
				Log.Write($"HIDE-FAILED {item.Exe} hwnd=0x{(long)item.Hwnd:X} pid={item.Pid} (窗口仍在，多因管理员权限被 UIPI 拦截)");
			}
		}
		return list;
	}

	public static bool HideShown(IntPtr hwnd, IntPtr selfHandle, uint selfPid,
		ICollection<string> filter, List<IntPtr> hidden, Dictionary<IntPtr, uint> owners)
	{
		uint pid; string reason;
		if (!IsHideCandidate(hwnd, selfHandle, selfPid, out pid, out reason)) return false;
		string exe = AppCatalog.ProcessExeOf(pid);
		bool selected = false;
		foreach (string name in filter)
			if (string.Equals(name, exe, StringComparison.OrdinalIgnoreCase)) { selected = true; break; }
		if (!selected) return false;
		Native.ShowWindow(hwnd, 0);
		if (Native.IsWindowVisible(hwnd)) return false;
		uint previous;
		if (owners.TryGetValue(hwnd, out previous) && previous == pid) return false;
		owners[hwnd] = pid;
		if (!hidden.Contains(hwnd)) hidden.Add(hwnd);
		return true;
	}
	public static bool EnforceHidden(IntPtr selfHandle, uint selfPid, ICollection<string> filter,
		List<IntPtr> hidden, Dictionary<IntPtr, uint> owners)
	{
		bool changed = false;
		for (int i = hidden.Count - 1; i >= 0; i--)
		{
			uint pid;
			Native.GetWindowThreadProcessId(hidden[i], out pid);
			uint expected;
			if (!Native.IsWindow(hidden[i]) || !owners.TryGetValue(hidden[i], out expected) || expected != pid)
			{
				owners.Remove(hidden[i]);
				hidden.RemoveAt(i);
				changed = true;
			}
		}
		var selected = new HashSet<string>(filter, StringComparer.OrdinalIgnoreCase);
		Native.EnumWindows((IntPtr hwnd, IntPtr unused) =>
		{
			uint pid; string reason;
			if (!IsHideCandidate(hwnd, selfHandle, selfPid, out pid, out reason) ||
				!selected.Contains(AppCatalog.ProcessExeOf(pid))) return true;
			Native.ShowWindow(hwnd, 0);
			if (!Native.IsWindowVisible(hwnd) && !owners.ContainsKey(hwnd))
			{
				owners[hwnd] = pid;
				hidden.Add(hwnd);
				changed = true;
			}
			return true;
		}, IntPtr.Zero);
		return changed;
	}
	public static void Restore(IEnumerable<IntPtr> hidden)
	{
		foreach (IntPtr item in hidden)
		{
			if (Native.IsWindow(item) && !Native.IsWindowVisible(item))
			{
				Native.ShowWindow(item, 4);
			}
		}
	}
}

}

namespace MoyuBossKey {
internal static class ModernTray {
 internal sealed class Record {
  public string Exe; public IntPtr Window; public uint Id, Pid; public long Started; public Guid Guid;
 }
 internal static string JournalPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "MoyuBossKeyLite", "tray-state.bin");
 [StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
 private struct IconData {
  public uint Size; public IntPtr Window; public uint Id, Flags, Callback; public IntPtr Icon;
  [MarshalAs(UnmanagedType.ByValTStr, SizeConst=128)] public string Tip;
  public uint State, StateMask;
  [MarshalAs(UnmanagedType.ByValTStr, SizeConst=256)] public string Info;
  public uint Version;
  [MarshalAs(UnmanagedType.ByValTStr, SizeConst=64)] public string Title;
  public uint InfoFlags; public Guid Guid; public IntPtr BalloonIcon;
 }
 [StructLayout(LayoutKind.Sequential)] private struct Identifier {
  public uint Size; public IntPtr Window; public uint Id; public Guid Guid;
 }
 [StructLayout(LayoutKind.Sequential)] private struct Rect { public int Left, Top, Right, Bottom; }
 private delegate bool EnumProc(IntPtr window, IntPtr parameter);
 [DllImport("user32.dll")] private static extern bool EnumWindows(EnumProc callback, IntPtr parameter);
 [DllImport("user32.dll")] private static extern bool EnumChildWindows(IntPtr window, EnumProc callback, IntPtr parameter);
 [DllImport("user32.dll", CharSet=CharSet.Unicode)] private static extern IntPtr FindWindowEx(IntPtr parent, IntPtr after, string cls, string title);
 [DllImport("user32.dll")] private static extern uint GetWindowThreadProcessId(IntPtr window, out uint pid);
 [DllImport("shell32.dll", CharSet=CharSet.Unicode, EntryPoint="Shell_NotifyIconW")]
 [return:MarshalAs(UnmanagedType.Bool)] private static extern bool NotifyIcon(uint message, ref IconData data);
 [DllImport("shell32.dll")] private static extern int Shell_NotifyIconGetRect(ref Identifier icon, out Rect rect);
 internal static bool HasRectangle(Record item) {
  var id = new Identifier {Size=(uint)Marshal.SizeOf(typeof(Identifier)), Window=item.Window, Id=item.Id, Guid=item.Guid};
  Rect rect; return Shell_NotifyIconGetRect(ref id, out rect)==0;
 }
 private static bool SetHidden(Record item, bool hidden) {
  var data = new IconData {Size=(uint)Marshal.SizeOf(typeof(IconData)), Window=item.Window, Id=item.Id, Guid=item.Guid,
   Flags=8u | (item.Guid==Guid.Empty ? 0u : 32u), StateMask=1, State=hidden ? 1u : 0u, Tip="", Info="", Title=""};
    if(!NotifyIcon(1, ref data)) return false;
  // Explorer updates its tray asynchronously after accepting NIM_MODIFY.
  for(int attempt=0;attempt<40;attempt++) {
   if(HasRectangle(item)!=hidden) return true;
   System.Threading.Thread.Sleep(25);
  }
  return false;
 }
 internal static List<Record> Find(ICollection<string> exes) {
  var filter = new HashSet<string>(exes, StringComparer.OrdinalIgnoreCase);
  var candidates = new Dictionary<string,List<Record>>(StringComparer.OrdinalIgnoreCase);
  using(var root=Registry.CurrentUser.OpenSubKey(@"Control Panel\NotifyIconSettings")) {
   if(root==null) return new List<Record>();
   foreach(string keyName in root.GetSubKeyNames()) using(var key=root.OpenSubKey(keyName)) {
    if(key==null) continue;
    string path=key.GetValue("ExecutablePath") as string;
    if(string.IsNullOrEmpty(path)) continue;
    string exe=Path.GetFileName(path); if(!filter.Contains(exe)) continue;
    object uid=key.GetValue("UID"), raw=key.GetValue("IconGuid"); Guid guid=Guid.Empty;
    if(raw is byte[] && ((byte[])raw).Length==16) guid=new Guid((byte[])raw);
    else if(raw is string) Guid.TryParse((string)raw, out guid);
    if(uid==null && guid==Guid.Empty) continue;
    List<Record> entries;
    if(!candidates.TryGetValue(exe,out entries)) candidates.Add(exe, entries=new List<Record>());
    entries.Add(new Record {Exe=exe, Id=uid==null ? 0u : unchecked((uint)Convert.ToInt64(uid)), Guid=guid});
   }
  }
    var owners=new Dictionary<uint,Tuple<string,long>>();
  foreach(string exe in candidates.Keys) foreach(var process in Process.GetProcessesByName(Path.GetFileNameWithoutExtension(exe))) {
   using(process) {try {owners[(uint)process.Id]=Tuple.Create(exe,process.StartTime.ToUniversalTime().Ticks);}
    catch(System.ComponentModel.Win32Exception) {} catch(InvalidOperationException) {}}
  }
  var result=new List<Record>(); var seen=new HashSet<IntPtr>();
  EnumProc visit=delegate(IntPtr window, IntPtr unused) {
   if(!seen.Add(window)) return true;
   uint pid; GetWindowThreadProcessId(window,out pid);
   Tuple<string,long> owner; if(!owners.TryGetValue(pid,out owner)) return true; try { {
    List<Record> entries;
    if(!candidates.TryGetValue(owner.Item1,out entries)) return true;
    foreach(var entry in entries) {
     var item=new Record {Exe=entry.Exe, Id=entry.Id, Guid=entry.Guid, Window=window, Pid=pid, Started=owner.Item2};
     // Only modify identities confirmed by Explorer, never guess icon IDs.
     if(HasRectangle(item) && !result.Exists(r=>item.Guid!=Guid.Empty ? r.Guid==item.Guid : r.Window==window && r.Id==item.Id && r.Guid==item.Guid)) result.Add(item);
    }
   }} catch(ArgumentException) {} catch(System.ComponentModel.Win32Exception) {} catch(InvalidOperationException) {}
   return true;
  };
  EnumWindows(delegate(IntPtr window,IntPtr unused) {visit(window,unused); EnumChildWindows(window,visit,IntPtr.Zero); return true;},IntPtr.Zero);
  // WinForms NotifyIcon uses message-only owner windows.
  IntPtr current=IntPtr.Zero;
  while((current=FindWindowEx(new IntPtr(-3),current,null,null))!=IntPtr.Zero) {
   visit(current,IntPtr.Zero); EnumChildWindows(current,visit,IntPtr.Zero);
  }
  return result;
 }
 private static List<Record> Load() {
  var records=new List<Record>(); if(!File.Exists(JournalPath)) return records;
  using(var reader=new BinaryReader(File.OpenRead(JournalPath))) {
   if(reader.ReadInt32()!=1) throw new InvalidDataException("Unknown tray journal version");
   int count=reader.ReadInt32(); if(count<0 || count>10000) throw new InvalidDataException("Invalid tray journal count");
   for(int i=0;i<count;i++) records.Add(new Record {Exe=reader.ReadString(),Window=new IntPtr(reader.ReadInt64()),
    Id=reader.ReadUInt32(),Pid=reader.ReadUInt32(),Started=reader.ReadInt64(),Guid=new Guid(reader.ReadBytes(16))});
  } return records;
 }
 private static void Save(List<Record> records) {
  Directory.CreateDirectory(Path.GetDirectoryName(JournalPath)); string temp=JournalPath+".tmp";
  using(var stream=new FileStream(temp,FileMode.Create,FileAccess.Write,FileShare.None)) {
   using(var writer=new BinaryWriter(stream,System.Text.Encoding.UTF8,true)) {
    writer.Write(1); writer.Write(records.Count);
    foreach(var item in records) {writer.Write(item.Exe);writer.Write(item.Window.ToInt64());writer.Write(item.Id);
     writer.Write(item.Pid);writer.Write(item.Started);writer.Write(item.Guid.ToByteArray());}
   } stream.Flush(true);
  }
  if(File.Exists(JournalPath)) File.Replace(temp,JournalPath,null); else File.Move(temp,JournalPath);
 }
 internal static List<Record> Hide(ICollection<string> exes) {
  var saved=Load(); var hidden=new List<Record>();
  foreach(var item in Find(exes)) {
   if(!saved.Exists(r=>r.Window==item.Window && r.Id==item.Id && r.Guid==item.Guid)) saved.Add(item);
   Save(saved); // Persist exact recovery identities before changing Explorer.
   if(SetHidden(item,true) && !HasRectangle(item)) hidden.Add(item);
  } return hidden;
 }
 internal static int Restore() {
  var pending=new List<Record>(); int restored=0;
  foreach(var item in Load()) {
   try {
    uint pid; GetWindowThreadProcessId(item.Window,out pid); if(pid!=item.Pid) continue;
    using(var process=Process.GetProcessById((int)pid)) if(process.StartTime.ToUniversalTime().Ticks!=item.Started) continue;
    if(SetHidden(item,false) && HasRectangle(item)) restored++; else pending.Add(item);
   } catch(ArgumentException) {} catch(System.ComponentModel.Win32Exception) {pending.Add(item);} catch(InvalidOperationException) {}
  }
  Save(pending); return restored;
 }
}
}
