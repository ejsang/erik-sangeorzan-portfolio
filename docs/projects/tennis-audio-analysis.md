# Analyzing Tennis Matches Based on Audio (MATLAB)

**Summary:** A signal processing project using MATLAB to analyze audio from tennis matches to detect ball hits, identify "out" calls vs. applause, and track game score automatically.

**Problem:** Automate the tracking of tennis match events and scoring using only audio cues.

**Approach:** Developed MATLAB algorithms to detect transients (ball hits), spectral features for applause vs. net hits, and implemented a state machine to track scoring.

**Results:** Successfully detected ball hits and applause in test clips; identified limitations in net hit detection for specific rallies.

Relevant files
- `main.m`: Driver script.
- `findBallHit.m`, `outidentification.m`, `findapplause.m`: Signal processing algorithms.

Skills demonstrated
- Audio Signal Processing (MATLAB)
- Algorithm Development (transient detection, spectral analysis)
- State Machine Logic for scoring

Why this is relevant to Shure
- Demonstrates fundamental audio signal processing and algorithm development skills using MATLAB, a standard tool for DSP prototyping.

## Project Website
For a detailed breakdown of the methodology and results, visit the [Project Website](https://ejsang.wixsite.com/eecs351project){:target="_blank"}.

## How to run / reproduce

- Requirements: MATLAB.
- Run `main.m` in MATLAB.
- The script analyzes the audio, prints the game score to the console, and generates plots for detected events.
- Note: The current algorithm has a known issue missing a net hit in rally 4, which affects scoring in subsequent rallies.

## Downloads
- [Code (zip)](../assets/tennis-audio-analysis/tennis-audio-code.zip){:target="_blank"}

### What to inspect
- Check `findBallHit.m` to see the transient detection logic.
- See `main.m` for the integration of detection algorithms into the game loop.
