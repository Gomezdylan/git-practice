# Retro Hockey

## Overview
Retro Hockey is a 2D top-down arcade hockey game built in Unity by 4 developers. Players skate, pass, shoot, and battle for puck control in fast-paced retro-style gameplay. The project includes custom physics, AI logic, shooting mechanics, collisions, and sound effects. There are 3 different modes: Freeplay, StanleyCup, and BCMode.

## Features
- Smooth skating and player movement system  
- Passing and shooting (wrist shot + slap shot)  
- AI players with decision-making (move, pass, shoot)  
- Puck possession logic  
- StickLogic + Shot classes using inheritance & dynamic binding  
- Cinemachine camera shake  
- Goal horn, hit sounds, puck SFX, background music  
- Clean UI menus  
- Mac/Android/Linux builds supported
- Animation States  

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

## Final Demo Video
- Coming Soon

## Team
- Dylan  
- Robbie
- Nathan
- Matt


