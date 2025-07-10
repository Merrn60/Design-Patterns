# Design Patterns Repository

This repository contains C# implementations of three fundamental design patterns from Software Engineering II: **Singleton**, **State**, and **Proxy**. Each pattern is implemented in a separate folder with clear, runnable code examples.

## Table of Contents
- [Overview](#overview)
- [Design Patterns](#design-patterns)
  - [Singleton Pattern](#singleton-pattern)
  - [State Pattern](#state-pattern)
  - [Proxy Pattern](#proxy-pattern)
- [How to Run](#how-to-run)
- [License](#license)

## Overview
This repository demonstrates the implementation of three design patterns commonly used in software engineering. Each pattern is implemented in C# and includes a console-based example to illustrate its functionality.

## Design Patterns

### Singleton Pattern
**File**: `Singleton/DatabaseConnectionManager.cs`

The Singleton pattern ensures that a class has only one instance and provides a global point of access to it. This example implements a `DatabaseConnectionManager` class that ensures a single instance for managing database connections.

- **Key Features**:
  - Thread-safe implementation using double-checked locking.
  - Private constructor to prevent instantiation.
  - Static method to access the single instance.

### State Pattern
**File**: `State/MusicPlayer.cs`

The State pattern allows an object to alter its behavior when its internal state changes. This example implements a `MusicPlayer` that transitions between `Stopped`, `Playing`, and `Paused` states.

- **Key Features**:
  - Defines a state interface (`IPlayerState`) and concrete states (`StoppedState`, `PlayingState`, `PausedState`).
  - The `MusicPlayer` context changes behavior based on the current state.
  - Demonstrates state transitions through `Play`, `Pause`, and `Stop` actions.

### Proxy Pattern
**File**: `Proxy/ProxyImage.cs`

The Proxy pattern provides a surrogate or placeholder for another object to control access to it. This example implements a `ProxyImage` class that lazily loads a `RealImage` when accessed.

- **Key Features**:
  - Implements lazy loading to defer expensive operations (e.g., loading an image from disk).
  - Uses an interface (`IImage`) to ensure compatibility between the proxy and real subject.
  - Demonstrates controlled access to the real object.

## How to Run
1. **Prerequisites**:
   - Install the .NET SDK (version 6.0 or later recommended).
   - A C# IDE like Visual Studio or Visual Studio Code.

2. **Steps**:
   - Clone this repository:
     ```bash
     git clone https://github.com/your-username/DesignPatternsRepository.git
