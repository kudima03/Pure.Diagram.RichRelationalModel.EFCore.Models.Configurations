# Pure.Diagram.RichRelationalModel.EFCore.Models.Configurations

EF Core `IEntityTypeConfiguration<T>` implementations for the **Pure.Diagram** rich relational model.

[![.NET build & test](https://github.com/kudima03/Pure.Diagram.RichRelationalModel.EFCore.Models.Configurations/actions/workflows/build-and-test.yml/badge.svg?branch=main)](https://github.com/kudima03/Pure.Diagram.RichRelationalModel.EFCore.Models.Configurations/actions/workflows/build-and-test.yml)
[![Build and Deploy](https://github.com/kudima03/Pure.Diagram.RichRelationalModel.EFCore.Models.Configurations/actions/workflows/publish-nuget.yml/badge.svg?branch=main)](https://github.com/kudima03/Pure.Diagram.RichRelationalModel.EFCore.Models.Configurations/actions/workflows/publish-nuget.yml)
[![NuGet](https://img.shields.io/nuget/v/Pure.Diagram.RichRelationalModel.EFCore.Models.Configurations)](https://www.nuget.org/packages/Pure.Diagram.RichRelationalModel.EFCore.Models.Configurations)
[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](LICENSE)

## Overview

`Pure.Diagram.RichRelationalModel.EFCore.Models.Configurations` provides EF Core type configurations for diagram rich relational model entities — diagrams, diagram types, and series — with column mappings, key constraints, max lengths, foreign key relationships, and Pure primitive converters/comparers.

## Configurations

| Type | Entity | Description |
|---|---|---|
| `DiagramConfiguration` | `DiagramEFCoreModel` | GUID PK, Title and Description columns, TypeId FK, one-to-many Series navigation |
| `DiagramTypeConfiguration` | `DiagramTypeEFCoreModel` | GUID PK, Name column (max 128) |
| `DiagramSeriesConfiguration` | `DiagramSeriesEFCoreModel` | GUID PK, DiagramId FK, Label and Source string columns |

## Dependencies

- [`Pure.Diagram.RichRelationalModel.EFCore.Models`](https://github.com/kudima03/Pure.Diagram.RichRelationalModel.EFCore.Models) — EF Core entity records
- [`Pure.Primitives.Abstractions.EFCore.Converters`](https://github.com/kudima03/Pure.Primitives.Abstractions.EFCore.Converters) — value converters for Pure primitive types
- [`Pure.Primitives.Abstractions.EFCore.ValueComparers`](https://github.com/kudima03/Pure.Primitives.Abstractions.EFCore.ValueComparers) — value comparers for Pure primitive types
