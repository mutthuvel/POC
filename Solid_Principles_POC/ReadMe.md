Here’s a quick summary of the **SOLID principles** and how they differ:

1. **Single Responsibility Principle (SRP)**:
   - **Focus**: A class should have one job or reason to change.
   - **Key Idea**: Promotes separation of concerns, ensuring each class has a single, focused responsibility.

2. **Open/Closed Principle (OCP)**:
   - **Focus**: Software should be **open for extension** but **closed for modification**.
   - **Key Idea**: Allows adding new functionality by extending existing code without changing it, enhancing maintainability.

3. **Liskov Substitution Principle (LSP)**:
   - **Focus**: Subclasses should be substitutable for their base classes without altering correctness.
   - **Key Idea**: Ensures derived classes behave consistently with base classes, preserving system integrity.

4. **Interface Segregation Principle (ISP)**:
   - **Focus**: No class should be forced to implement interfaces it doesn’t use.
   - **Key Idea**: Encourages small, specific interfaces to keep code modular and avoid unnecessary methods.

5. **Dependency Inversion Principle (DIP)**:
   - **Focus**: High-level modules should depend on abstractions, not low-level details.
   - **Key Idea**: Reduces coupling between modules by depending on interfaces or abstractions, promoting flexibility.

---

**Key Differences**:
- **SRP** deals with separation of responsibilities.
- **OCP** focuses on extending functionality without modifying existing code.
- **LSP** ensures behavioral correctness of derived classes.
- **ISP** encourages creating small, relevant interfaces.
- **DIP** promotes decoupling between high-level and low-level modules by relying on abstractions.
