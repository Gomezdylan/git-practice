# Retro Hockey

## Overview
Retro Hockey is a 2D top-down arcade hockey game built in Unity. Players skate, pass, shoot, and battle for puck control in fast-paced retro-style gameplay. The project includes custom physics, AI logic, shooting mechanics, collisions, sound effects, and polished camera work.

## Features
- Smooth skating & player movement system  
- Passing and shooting (wrist shot + slap shot)  
- AI players with decision-making (move, pass, shoot)  
- Goalie mechanics and puck possession logic  
- StickLogic + Shot classes using inheritance & dynamic binding  
- Cinemachine camera shake  
- Goal horn, hit sounds, puck SFX, background music  
- Clean UI menus  
- Mac/Windows builds supported  

## Technical Highlights
- `Movement.cs` handles acceleration, drag, and velocity  
- `Puck.cs` uses Rigidbody2D force-based physics  
- `WristShot` and `SlapShot` override the base `Shot` class  
- Offensive AI uses distance-to-goal & teammate evaluation  
- Dynamic binding example: `Execute()` in AI subclasses  
- Organized folder structure and custom scripts  

## Controls
**Keyboard:**
- Arrow Keys — Move  
- Space — Shoot (tap = wrist shot, hold = slap shot)  
- P — Pass  
- Esc — Pause  

## Audio System
Handled through `SMScript` (Sound Manager):
- Hit sounds  
- Puck collisions  
- Skating  
- Goal horn  
- Background music  

## Demo Video
A full start-to-finish gameplay video is provided for final presentation.

## Team
- Dylan  
- Robbie
- Nathan
- Matt


