# GitHub Copilot Instructions for RimWorld Modding Project

## Mod Overview and Purpose
The "ZeroTech" mod is designed to enhance the player's experience in RimWorld by introducing futuristic technologies and systems. This mod adds a variety of new buildings, items, components, and gameplay mechanics that simulate advanced technology, expanding the lore and playstyle options for players interested in a high-tech colony.

## Key Features and Systems
- **Building_GelMaker**: Functions as a storage building that processes and stores a new type of gel.
- **Comp_SelfDamage**: Introduces self-damaging mechanics to certain objects, adding risk-reward elements.
- **LingComp_TimeBomb**: Implements a time bomb component that can be attached to objects, allowing timed explosions.
- **PowerBelt**: Provides colonists with a wearable item that can utilize and manage power reserves for various high-tech devices.
- **ReResearchAndAddBuff**: Creates enhanced research outcomes that reward players with specific buffs.
- **WeatherEvent_LightningStrikeNoFire**: Custom weather event that generates lightning strikes without fire, simulating controlled electrical storms.

## Coding Patterns and Conventions
- **Class Names**: Follow PascalCase naming convention (e.g., `Building_GelMaker`, `Comp_SelfDamage`).
- **Method Overloading**: Utilized in classes such as `PowerBelt` for flexible functionality (e.g., `UsePower` with different parameter sets).
- **Inheritance**: Classes often derive from `ThingComp`, `Building`, and other base RimWorld classes to extend functionality.
- **Component Properties**: Classes like `CompProperties` are used to define adjustable properties for components, facilitating customization.

## XML Integration
While XML files define the static content like item definitions, recipes, and research projects, ensure you integrate these properly into your C# logic:
- Tie in XML-defined items with C# classes for dynamic interactions.
- Use Defs in XML to leverage existing RimWorld definitions, extended through your custom C# logic.

## Harmony Patching
- **Purpose**: Modify base game methods to accommodate new functionality without altering core files.
- **Usage**: Use Harmony to apply patches where new systems interact with or modify existing game mechanics.
- **Example**: Patching the `WeatherManager` to include `WeatherEvent_LightningStrikeNoFire`.

## Suggestions for Copilot
- **Code Completion**: When writing new features, leverage Copilot for auto-completing method signatures and common RimWorld patterns.
- **Pattern Recognition**: Use Copilot to identify frequently used design patterns in RimWorld modding, ensuring consistency with community standards.
- **Integration Points**: Rely on Copilot to suggest integration points between C# classes and XML definitions, streamlining the development process.
- **Patch Suggestions**: Use Copilot to help identify potential methods suitable for Harmony patching based on method goals and usage patterns.

By following these guidelines and leveraging GitHub Copilot, you can efficiently develop, maintain, and enhance the "ZeroTech" mod for RimWorld, ensuring a high-quality experience for players exploring advanced technological themes.
