# GitHub Copilot Instructions for ZeroTech-Core (Continued) Mod

## Mod Overview and Purpose

ZeroTech-Core (Continued) is an update to the LingLuos mod for RimWorld. It introduces a new technology tree called Lingzi Technology, which provides several basic and core materials for players to use in their settlements. The mod also includes various new buildings, items, and traders that can be used to enhance the gameplay experience.

## Key Features and Systems

### Technology Tree

The Lingzi Technology tree includes several basic materials such as Zero gel, Zero fabric, and Zero sub-alloy, as well as several core materials such as Zero mechanical core and Zero energy core. These materials can be used to create new buildings, weapons, and other items.

### Buildings

The mod introduces several new buildings that can be used to create and use the materials and items provided by the Lingzi Technology tree. These buildings include the ZeroTech Workshop, which is the core workbench for Lingzi Technology, and the Gel Maker, which can polish any object into gel and occasionally produce special by-products.

### Items

The mod includes several new items that can be used in various ways. These items include the Crystal Pill, which can be used to increase a colonist's mood, and the Zero energy core, which can be used as an energy source for some weapons or to upgrade skill levels.

### Traders

The mod also introduces several new traders that can be used to sell and buy items from players. These traders include the Zero traders, which can sell any marketable items and will not refuse.

## Coding Patterns and Conventions

### C# Code

The ZeroTech-Core (Continued) mod uses C# code to implement various features and systems. The code follows standard C# conventions and patterns, such as the use of classes and methods to encapsulate functionality and the use of interfaces to define contract for objects.

### XML Integration

The mod uses XML files to define various game elements, such as recipes, things, and terrain. These files follow standard XML conventions and patterns, such as the use of tags and attributes to define properties and relationships between elements.

### Harmony Patching

The mod uses Harmony patching to modify existing game code and add new functionality. Harmony patching is a popular technique in RimWorld modding and allows modders to modify game code without affecting the original codebase.

## Suggestions for Copilot

GitHub Copilot can be a powerful tool for RimWorld modding projects. To make the most of Copilot, here are some suggestions:

- Use Copilot to quickly generate code snippets and templates for new features and systems.
- Use Copilot to suggest code improvements and optimizations, such as refactoring code to improve readability or performance.
- Use Copilot to suggest code changes that are consistent with the coding patterns and conventions used in the mod.

## Conclusion

ZeroTech-Core (Continued) is a mod that provides a new technology tree and various new features and systems for RimWorld players. It uses C# code, XML files, and Harmony patching to implement its features and systems. GitHub Copilot can be a valuable tool for modders working on this project, and following the coding patterns and conventions used in the mod can help ensure that code changes are consistent and maintainable.

## Project Solution Guidelines
- Relevant mod XML files are included as Solution Items under the solution folder named XML, these can be read and modified from within the solution.
- Use these in-solution XML files as the primary files for reference and modification.
- The `.github/copilot-instructions.md` file is included in the solution under the `.github` solution folder, so it should be read/modified from within the solution instead of using paths outside the solution. Update this file once only, as it and the parent-path solution reference point to the same file in this workspace.
- When making functional changes in this mod, ensure the documented features stay in sync with implementation; use the in-solution `.github` copy as the primary file.
- In the solution is also a project called Assembly-CSharp, containing a read-only version of the decompiled game source, for reference and debugging purposes.
- For any new documentation, update this copilot-instructions.md file rather than creating separate documentation files.


## Hard rules (must follow)
- Do NOT run commands that modify the repo (no git commit, git apply, dotnet format) unless explicitly asked.
- Prefer minimal reads: read only the smallest code region needed (around the suspicious lines).
- When mentioning SonarQube issues, automatically use the SonarQube MCP service to fetch and address issues instead of making inferred fixes without querying SonarQube first.
- When mentioning the rimworld log, automatically use the Rimworld MCP service to fetch the log.

