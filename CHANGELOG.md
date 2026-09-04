# Changelog

All notable changes to Pure.Diagram.RichRelationalModel.EFCore.Models.Configurations are
documented here.

Format follows [Keep a Changelog](https://keepachangelog.com/en/1.1.0/).

---

## [0.1.0-preview.2.1.0] — 2026-06-23

- Maintenance release: dependency and build updates.

## [0.1.0-preview.2.0.2] — 2026-06-07

- Maintenance release: dependency and build updates.

## [0.1.0-preview.2.0.1] — 2026-06-07

- Maintenance release: dependency and build updates.

## [0.1.0-preview.2.0.0] — 2026-04-20

### Changed

- **Breaking:** `SeriesConfiguration` renamed to `DiagramSeriesConfiguration`, now
  implementing `IEntityTypeConfiguration<DiagramSeriesEFCoreModel>` (previously
  `IEntityTypeConfiguration<SeriesEFCoreModel>`), tracking the corresponding rename in
  `Pure.Diagram.RichRelationalModel.EFCore.Models`.

## [0.1.0-preview.1.0.1] — 2026-02-18

- Maintenance release: dependency and build updates.

## [0.1.0-preview.1.0.0] — 2026-02-18

- Maintenance release: dependency and build updates.

## [0.1.0-preview.0.2.1] — 2026-02-18

### Changed

- **`DiagramConfiguration`**, **`SeriesConfiguration`**, and
  **`DiagramTypeConfiguration`** now register value comparers (`GuidValueComparer`,
  `StringValueComparer` from `Pure.Primitives.Abstractions.EFCore.ValueComparers`) on
  their converted `Guid` and `string` properties, improving EF Core change-tracking
  accuracy for those properties.

## [0.1.0-preview.0.2.0] — 2026-02-18

- Maintenance release: dependency and build updates.

## [0.1.0-preview.0.1.0] — 2026-02-17

### Added

- **`DiagramTypeConfiguration`** — `IEntityTypeConfiguration<DiagramTypeEFCoreModel>`
  configuring `Id` as a `Guid` key with no generated value, and a required `Name`
  (max length 64) with a unique index.
- **`SeriesConfiguration`** — `IEntityTypeConfiguration<SeriesEFCoreModel>` configuring
  `Id` and `DiagramId` (`Guid`), and required `Label`/`Source` (string, max length 64).
- **`DiagramConfiguration`** — `IEntityTypeConfiguration<DiagramEFCoreModel>`
  configuring `Id` as a `Guid` key, required `Title` (max length 64) and
  `Description` (string), a `TypeId` foreign key to `DiagramTypeEFCoreModel` via
  `TypeNavigation`, and a one-to-many relationship to `SeriesEFCoreModel` via
  `SeriesNavigation`.
