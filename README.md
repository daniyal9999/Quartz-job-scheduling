# Quartz Job Scheduling

Explore **Quartz** for job scheduling with detailed explanations of Cron expressions.

## Cron Expression Format

A **Cron expression** defines when a job should run. It typically has **five** fields, with an optional **sixth field** for the year.

### Cron Fields:
1. **Minute (0-59)** – When the job should run in the minute of the hour.
2. **Hour (0-23)** – When the job should run during the day (24-hour format).
3. **Day of the Month (1-31)** – Specific day of the month.
4. **Month (1-12)** – Month of the year.
5. **Day of the Week (0-6)** – Day of the week (0 = Sunday).
6. **Year (optional)** – Specific year (e.g., 2024).

### Special Characters:
- `*` – Matches any value.
- `L` – Last (e.g., last weekday of the month).
- `5L` – Last Friday of the month.

### Example Cron Expression: `0 15 * 1 5L 2025`
- **Minute (0):** At the 0th minute (top of the hour).
- **Hour (15):** At 3 PM.
- **Day of the Month (*):** Any day.
- **Month (1):** January.
- **Day of the Week (5L):** Last Friday of the month.
- **Year (2025):** Runs in the year 2025.

This expression schedules a job to run on **the last Friday of January 2025 at 3 PM**.

---

### Resources:
To generate a Cron expressions, visit: [crontab.guru](https://crontab.guru/)
