# GitHub Copilot Instructions for Better Records Tab (Continued)

## Mod Overview and Purpose
**Better Records Tab (Continued)** is an enhancement of the original mod by Odie that improves the UI of the Records tab in RimWorld. The purpose of this mod is to provide players with a visual representation of their colonists' achievements through color-coded records, making it easier to compare and analyze performance metrics among colonists.

## Key Features and Systems
- **Color-Coded Records**: The mod applies colors to the list of records for each colonist:
  - **Green text** indicates that the selected colonist has achieved the highest value in that record among all colonists.
  - **Yellow text** highlights that the selected colonist does not have the highest value, but the record is existent.
  - **White text** shows that no colonist has yet achieved this record, indicating untapped potential.
- This feature enables players to quickly identify which colonist excels in specific tasks, aiding in task allocation and strategy formulation.

## Coding Patterns and Conventions
- Use well-structured and clear naming conventions for classes and methods. For instance, the core functionality resides in `DrawRecordplus` and `RecordsPlus` classes.
- Adopt consistent indentation and formatting to ensure readability and maintainability of the codebase.
- Emphasize code comments, especially in areas where complex logic or calculations are performed, to aid understanding and future modifications.

## XML Integration
- Although there are currently no XML files directly associated with this mod, XML integration can be considered for configuration or localization purposes in future updates. XML can be used to define mod configurations or to support multiple languages by providing translation strings.

## Harmony Patching
- The mod depends on Harmony (brrainz.harmony) to modify and extend the functionality of the vanilla game's records tab.
- The principal patch is implemented in the `DrawRecordplus` class, where the `Prefix` method modifies the behavior of existing game functions to apply the color coding feature.
- Ensure all Harmony patches are correctly annotated and handle cases where the game configuration might change in future updates, such as version checking and conditional patching.

## Suggestions for Copilot
- **Auto-Completion**: Use Copilot to suggest method names and parameters that conform to established code patterns. For example, when creating new methods or classes.
- **Error Handling**: Implement improved error handling using try-catch blocks. Copilot can assist in generating common error handling patterns that comply with practices in the larger RimWorld modding community.
- **Optimization**: Utilize Copilot to identify redundant code or suggest optimizations, particularly when dealing with rendering elements in the UI.
- **Documentation**: Generate placeholder comments for each function with Copilot to prioritize detailed inline documentation that explains non-trivial code logic. 
- **Testing**: Develop comprehensive test cases with Copilot's help to ensure the mod’s features work seamlessly alongside other mods. This includes creating mock scenarios to test Harmony patches under various game states.

The Better Records Tab (Continued) mod is optimized for visual clarity and ease of use, aiding players in achieving a more strategic overview of their colonists' capabilities. With continued enhancements and community feedback, this mod aims to remain an indispensable tool for RimWorld players seeking superior colony management.

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

