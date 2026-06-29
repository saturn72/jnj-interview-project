# User Session Service — Implementation Challenge

## Context

You are joining the team responsible for the **User Session Service** — a backend service that sits at the edge of the platform and tracks active user interactions.

Every time a user interacts with any part of the platform (a request comes in from the outside world), that interaction is recorded as a user session. A session is considered **active** if the user has interacted with the platform **at least once in the past 60 minutes**.

The service is a high-traffic, production-grade component — it receives **millions of requests per second** and must respond with minimal latency.

---

## Your Task

The codebase already has the skeleton in place — interfaces, the domain model, and the project structure. **Your job is to implement the service logic.**

A few things to keep in mind:

- **Session data must be persisted** — it cannot live only in memory. If the service restarts, the data should survive.
- **Performance is a hard requirement** — lookups and writes must be fast enough to hold up under extreme load.
- The `HasActiveSession` check is on the hot path — it will be called on every single request.

---

## What "Active Session" Means

A user has an active session when they have interacted with the platform **within the last hour**. The `SessionExpiresOnUtc` property on the `UserSession` entity represents the point in time (as a Unix timestamp) after which the session is no longer valid.

---

## Acceptance Criteria

- `HasActiveSession(phoneNumber)` returns `true` if a non-expired session exists for that phone number, `false` otherwise.
- Creating or updating a session correctly sets or extends the expiry window.
- The implementation can realistically handle millions of requests per second.
- Data is durable across service restarts.
