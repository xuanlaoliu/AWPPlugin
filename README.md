# AWPPlugin

<p align="center">
  <a href="#readme-zh">🇨🇳 中文</a> · <a href="#readme-en">🇬🇧 English</a>
</p>

---

<a id="readme-zh"></a>
## 🇨🇳 中文

[![Exiled](https://img.shields.io/badge/EXILED-9.0.0-blue)](https://github.com/Exiled-Team/EXILED)
[![LabAPI](https://img.shields.io/badge/LabAPI-1.1.4+-green)](https://github.com/northwood-studios/LabAPI)
[![License](https://img.shields.io/badge/License-MIT-yellow)](LICENSE)

**AWPPlugin** 是一个基于 [EXILED](https://github.com/Exiled-Team/EXILED) 框架的 SCP: Secret Laboratory 服务器插件，为游戏添加了一把名为 **AWP** 的自定义狙击枪。

### 功能

- **自定义武器 AWP** — 基于 E11 步枪模型，伤害 100，弹匣仅 5 发
- **高额伤害** — 单发伤害 100，爆头即秒
- **自动生成** — 混沌分裂者 / 九尾狐重生时，在两个固定坐标各生成 2 把（共 4 把）
- **SCP-3114 免疫** — 3114 无法拾取 AWP
- **拾取提示** — 玩家拾取时收到广播提示
- **EXILED CustomItems** — 不掉落退化，始终保留 AWP 属性

### 安装

1. 下载最新版本的 [AWPPlugin.dll](../../releases)
2. 放入服务器 `EXILED/Plugins/` 目录
3. 重启服务器（或使用 `reload plugins` 指令）

### 依赖

| 依赖 | 版本 |
|------|------|
| EXILED | ≥ 9.0.0 |
| LabAPI | ≥ 1.1.4 |

### 配置

插件开箱即用，无需额外配置。如需修改，可在 `EXILED/Configs/AWPPlugin.yml` 中写入：

```yaml
AWPPlugin:
  is_enabled: true
  debug: false
```

| 配置项 | 类型 | 默认值 | 说明 |
|--------|------|--------|------|
| `is_enabled` | `bool` | `true` | 是否启用插件 |
| `debug` | `bool` | `false` | 是否输出调试日志 |

### 自行编译

#### 前置要求

- [.NET Framework 4.8 SDK](https://dotnet.microsoft.com/download/dotnet-framework/net48)（或 Visual Studio 2022）
- 游戏服务端文件

#### 步骤

```bash
git clone https://github.com/your-username/AWPPlugin.git
cd AWPPlugin
dotnet build -c Release
```

编译产物位于 `bin/` 目录下。

### 武器参数

| 属性 | 值 |
|------|-----|
| 基础物品 | `GunE11SR` |
| 伤害 | 100 |
| 弹匣容量 | 5 发 |
| 弹药类型 | 5.56mm（可正常换弹） |
| 重量 | 3.5 |

### 生成坐标

| 坐标 | 位置说明 |
|------|----------|
| `(0.614, 302.5, -39.853)` | 混沌分裂者重生点 |
| `(134.933, 297.552, -43.236)` | 九尾狐重生点 |

> 两个坐标各生成 2 把 AWP，共 4 把。

### 项目结构

```
AWPPlugin/
├── Plugin.cs           # 插件主类
├── AWP.cs              # 自定义武器类
├── EventHandlers.cs    # 事件处理
├── Config.cs           # 配置类
├── AWPPlugin.csproj    # 项目文件
├── README.md           # 本文件
└── LICENSE             # MIT 许可证
```

### 开源许可

[MIT](LICENSE)

---

<a id="readme-en"></a>
## 🇬🇧 English

[![Exiled](https://img.shields.io/badge/EXILED-9.0.0-blue)](https://github.com/Exiled-Team/EXILED)
[![LabAPI](https://img.shields.io/badge/LabAPI-1.1.4+-green)](https://github.com/northwood-studios/LabAPI)
[![License](https://img.shields.io/badge/License-MIT-yellow)](LICENSE)

**AWPPlugin** is an [EXILED](https://github.com/Exiled-Team/EXILED)-based plugin for SCP: Secret Laboratory that adds a custom sniper rifle named **AWP** to the game.

### Features

- **Custom weapon AWP** — Based on the E11 rifle model, 100 damage, 5-round magazine
- **High damage** — 100 damage per shot, one-hit kill on headshots
- **Auto spawn** — Spawns 2 AWPs at each of two fixed locations (4 total) when Chaos Insurgency / Nine-Tailed Fox respawn
- **SCP-3114 immune** — SCP-3114 cannot pick up the AWP
- **Pickup broadcast** — Players receive a broadcast when picking up the AWP
- **EXILED CustomItems** — Retains AWP properties on drop or death, never reverts to a regular E11

### Installation

1. Download the latest [AWPPlugin.dll](../../releases)
2. Place it in the server's `EXILED/Plugins/` directory
3. Restart the server (or use the `reload plugins` command)

### Dependencies

| Dependency | Version |
|------------|---------|
| EXILED | ≥ 9.0.0 |
| LabAPI | ≥ 1.1.4 |

### Configuration

The plugin works out of the box. To customize, add to `EXILED/Configs/AWPPlugin.yml`:

```yaml
AWPPlugin:
  is_enabled: true
  debug: false
```

| Option | Type | Default | Description |
|--------|------|---------|-------------|
| `is_enabled` | `bool` | `true` | Enable the plugin |
| `debug` | `bool` | `false` | Enable debug logging |

### Building from Source

#### Prerequisites

- [.NET Framework 4.8 SDK](https://dotnet.microsoft.com/download/dotnet-framework/net48) (or Visual Studio 2022)
- Game server assemblies

#### Steps

```bash
git clone https://github.com/your-username/AWPPlugin.git
cd AWPPlugin
dotnet build -c Release
```

Output will be in the `bin/` directory.

### Weapon Stats

| Property | Value |
|----------|-------|
| Base item | `GunE11SR` |
| Damage | 100 |
| Magazine | 5 rounds |
| Ammo type | 5.56mm (reloadable) |
| Weight | 3.5 |

### Spawn Locations

| Coordinates | Location |
|------------|----------|
| `(0.614, 302.5, -39.853)` | Chaos Insurgency spawn |
| `(134.933, 297.552, -43.236)` | Nine-Tailed Fox spawn |

> 2 AWPs spawn at each location for a total of 4 per wave.

### Project Structure

```
AWPPlugin/
├── Plugin.cs           # Main plugin class
├── AWP.cs              # Custom weapon class
├── EventHandlers.cs    # Event handlers
├── Config.cs           # Configuration class
├── AWPPlugin.csproj    # Project file
├── README.md           # This file
└── LICENSE             # MIT license
```

### License

[MIT](LICENSE)
