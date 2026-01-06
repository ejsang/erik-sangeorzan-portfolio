# Real-Time Audio Separation of Human Voices

**Summary:** Real-time source separation project combining embedded Teensy audio acquisition (I2S), UART streaming, Raspberry Pi multicore processing, and a Python GUI for real-time playback and visualization. Demonstrates embedded audio capture, DSP algorithms, synchronization, and performance engineering.

Problem → Approach → Results
- Problem: Build a small-form-factor array to capture and separate human voices in real-time.
- Approach: Implement low-latency audio capture on Teensy (I2S), transmit via UART to a Raspberry Pi, perform online ICA/FFT-based processing with multiprocessing, and provide a multithreaded Python GUI for playback/visualization.
- Results: Working demo with real-time playback, written report and poster, performance tradeoffs documented.

Relevant files
- `Project Samples/Real-Time Audio Separation of Human Voices (Python, C)/src/valuecheck.ino` (Teensy firmware)
- `.../src/analyze_fft1024o.cpp`, `setI2Sfreq.cpp` (embedded audio handling)
- `.../src/multiproc_cogent.py`, `ui3_1_maxplayback.py` (Raspberry Pi processing & GUI)
- Report and slides: `2021-Team-2-final.pdf`, `2021-Team-2-slides.pdf`.

Skills demonstrated
- C/C++ on embedded platforms (I2S, UART), Python multiprocessing and multithreading
- Real-time DSP (FFT, ICA), FIR filtering (low-pass)
- Hardware synchronization using GPIO, performance tuning and profiling

Why this is relevant to Shure
- Directly maps to audio capture and real-time DSP experience required for professional audio products; shows experience with embedded audio pipelines, low-latency processing, and cross-platform integration.

## How to run / reproduce

Hardware
- Teensy boards with Audio Shield (or equivalent), a Raspberry Pi (4 recommended), microphones (or test audio), and a UART connection between Teensy and Pi.

Quick steps
- Run the self-contained demo: open `src_computer_runnable_demo/` and follow its README.
- On the Raspberry Pi (or laptop):
  - Create a Python virtualenv and install any dependencies (if present).
  - Run:

```bash
python3 src/multiproc_cogent.py
python3 src/ui3_1_maxplayback.py
```

- On each Teensy: flash `src/valuecheck.ino` (use Arduino IDE / Teensy Loader) and set I2S/UART parameters as described in `OVERVIEW.txt`.

Notes
- Real-time performance depends on available CPU cores and tuning parameters — see `OVERVIEW.txt` and `USAGE.txt` for recommended settings and bottlenecks.