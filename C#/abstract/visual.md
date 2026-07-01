                    Car (ABSTRACT)
                    ┌─────────────┐
                    │ GetColor()  │ ← BLANK! No color
                    │ (abstract)  │
                    └─────────────┘
                           │
        ┌──────────────────┼──────────────────┐
        ▼                  ▼                  ▼
    Ferrari            Lamborghini          Tesla
    ┌──────────┐       ┌──────────┐       ┌──────────┐
    │ Red      │       │ Yellow   │       │ Silver   │
    └──────────┘       └──────────┘       └──────────┘
    
    Each child PROVIDES its own color not the parent