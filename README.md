# About

This outputs the Primary Volume Descriptor Creation Date of a ISO 9660 file.

This is used in [rgl/windows-evaluation-isos-scraper](https://github.com/rgl/windows-evaluation-isos-scraper).

# Usage

Run as a dotnet project:

```bash
dotnet run my.iso
```

Run as a PowerShell script:

```powershell
Add-Type -Path IsoInfo.cs
[IsoInfo]::GetVolumeCreationDate('my.iso').ToString('O')
```

As an alternative, the Creation Date can also be obtained with the [`isoinfo` tool](http://manpages.ubuntu.com/manpages/focal/man1/isoinfo.1.html) (included in the [`genisoimage` package](https://packages.ubuntu.com/focal/genisoimage)):

```bash
isoinfo -debug -d -i my.iso
```

# References

* [ISO 9660 file format](https://wiki.osdev.org/ISO_9660)
