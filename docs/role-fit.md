# Role Fit — Shure Senior Embedded Software Engineer

**Context:** This page maps the Shure job requirements to specific project evidence in this portfolio. Each section below corresponds to a key requirement, with links to relevant projects and explanations of how they demonstrate the skill.

## Design, develop and test embedded software and associated components for audio products (C/C++)

- **[Real-Time Audio Separation](projects/real-time-audio-separation.md){:target="_blank"}** — Teensy firmware, I2S/UART C/C++ code, Raspberry Pi processing and multithreaded Python demos demonstrating low-latency embedded audio capture and processing.
- **[Stratum Synthesizer](projects/stratum-synthesizer.md){:target="_blank"}** — assembly-level audio engine and drivers showing deep knowledge of audio signal path and constraints.

## Hardware drivers, embedded software applications, audio and control networking (C/C++)

- **[Stratum Synthesizer](projects/stratum-synthesizer.md){:target="_blank"}** — speaker and SD drivers, low-level peripheral control.
- **[Zumo Shield Robot](projects/zumo-shield-robot.md){:target="_blank"}** — STM32 PWM, timers, UART and GPIO; illustrates driver usage and hardware control.

## Real-time, multitasking, RTOS concepts and debugging (Embedded Linux/FreeRTOS/etc)

- **[Real-Time Audio Separation](projects/real-time-audio-separation.md){:target="_blank"}** — real-time constraints, multicore/multithreaded processing and synchronization.
- **[Zumo Shield Robot](projects/zumo-shield-robot.md){:target="_blank"}** — real-time control loop design and hardware timing considerations (timers, interrupts, PWM).

## Networking & protocols (UART, I2S, possibility to work with Ethernet/TCP/UDP/Wi-Fi)

- **[Real-Time Audio Separation](projects/real-time-audio-separation.md){:target="_blank"}** — I2S audio capture and UART streaming; demonstrates protocol-level understanding and embedded networking concepts.

## Software architecture, design, and testing (reviews, unit/integration tests)

- All projects include design notes and reports; the portfolio includes a test-oriented project ([Toyota Auto-Validation](projects/toyota-auto-validation.md){:target="_blank"}) and unit tests in other repos (e.g., the archived Glasgow repo had tests). I prioritize clear documentation and testability.

## Hardware debugging and release processes

- **[Zumo Shield Robot](projects/zumo-shield-robot.md){:target="_blank"}** and **[Stratum Synthesizer](projects/stratum-synthesizer.md){:target="_blank"}** show hardware bring-up, telemetry, and iterative debugging workflows; [Toyota demo](projects/toyota-auto-validation.md){:target="_blank"} shows validation and reporting practices.

## Version control and documentation

- Full repositories and README/USAGE/OVERVIEW docs are included with each project; this portfolio itself is version-controlled and deploy-ready.

---

