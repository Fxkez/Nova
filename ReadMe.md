<div align="center">

![][badge-license]
![][badge-actions]
![][badge-downloads]
[![][badge-latest]][repo-latest]
[![][badge-discord]][discord-invite]
![][badge-stars]

</div>

Nova is a custom bootstrapper for Roblox, forked from [Fishstrap][fishstrap]
(pronounced fish-strap), which is itself based on [Bloxstrap][bloxstrap]
(pronounced blox-strap). Nova builds on that foundation with additional
features focused on customization, script execution, and identity spoofing.

If you found any bugs, please [open an issue here][repo-new-issue] or make a new
post in [our Discord server][discord-invite].

> [!NOTE]
> Nova is an application for **Windows 10 and above.** For other operating
> systems, such as macOS and various Linux distributions, you can try
> [AppleBlox][appleblox] and [Sober][sober] respectively.

## Features

Nova includes everything from Fishstrap, plus:

- **Auto-execute scripts** - write and save Luau scripts in the built-in
  editor (with syntax highlighting) that run automatically on launch
- **Internal & external executors** - point Nova at executor folders and have
  them launch automatically with Roblox, with per-entry enable toggles
- **Spoofer** - clears Roblox storage and identifiers on launch for a clean
  client state

Inherited from Fishstrap and Bloxstrap:

- Detailed server information using [RoValra][rovalra]'s API
- Support for Roblox Studio
- Unhidden FastFlags editor
  - You cannot apply FastFlags not present in the allowlist. This does not
    affect Roblox Studio. [Learn more][devforum-fflags]
- Global Basic Settings editor
  - Ability to increase frame rate cap, toggle quality levels and more
- Cache cleaner, channel switcher and many more

## Special thanks

- [Bloxstrap][bloxstrap] and [Fishstrap][fishstrap] for the foundation Nova is built on
- [Valra](https://github.com/NotValra) for providing their API
- Other independent contributors

<div align="center">

![][repo-showcase-light]
![][repo-showcase-dark]

</div>

[badge-license]:   https://img.shields.io/github/license/Fxkez/Nova?style=flat-square
[badge-actions]:   https://img.shields.io/github/actions/workflow/status/Fxkez/Nova/ci-release.yml?branch=main&style=flat-square&label=builds
[badge-downloads]: https://img.shields.io/github/downloads/Fxkez/Nova/latest/total?style=flat-square&color=981bfe
[badge-latest]:    https://img.shields.io/github/v/release/Fxkez/Nova?style=flat-square&color=7a39fb
[badge-discord]:   https://img.shields.io/discord/1388457225609150505?style=flat-square&logo=discord&logoColor=white&logoSize=auto&label=discord&color=4d3dff
[badge-stars]:     https://img.shields.io/github/stars/Fxkez/Nova?style=flat-square&color=dd9900

[repo-latest]:    https://github.com/YOURUSER/nova/releases/latest
[repo-new-issue]: https://github.com/YOURUSER/nova/issues/new/choose
[repo-showcase-dark]:   https://github.com/YOURUSER/nova/raw/main/Images/Showcase-Dark.png#gh-dark-mode-only
[repo-showcase-light]:  https://github.com/YOURUSER/nova/raw/main/Images/Showcase-Light.png#gh-light-mode-only

[discord-invite]: https://discord.gg/RFGz4Vtgb6

[fishstrap]: https://github.com/fishstrap/fishstrap
[bloxstrap]: https://bloxstraplabs.com
[appleblox]: https://github.com/AppleBlox/appleblox
[sober]:     https://sober.vinegarhq.org
[rovalra]:   https://www.rovalra.com
[devforum-fflags]: https://devforum.roblox.com/t/allowlist-for-local-client-configuration-via-fast-flags/3966569
