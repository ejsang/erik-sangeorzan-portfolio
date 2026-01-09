# Glasgow Index Analyzer (ARCHIVED)

**Removed from public portfolio**

This project has been removed from the public portfolio at the owner's request (2026-01-06). The original content has been archived in `docs/projects/archive/glasgow-index-analyzer.md`. If you need to restore the page, contact the owner.

## How to run / reproduce

- Create a Python virtual environment and install dependencies:

```bash
python -m venv venv
venv\Scripts\activate     # on Windows
pip install -r requirements.txt
```

- Example analysis command:

```bash
python glasgow_index_analyzer.py --analyze --oscar-data-root <DATA_DIR> --settings-history-csv <settings.csv> --oscar-csv <oscar.csv> --output ./my_results.csv
```

- Run tests / validation:

```bash
python -m pytest -q
# or run specific tests
python test_sleep_integration.py
python test_sleep_mapping.py
```

- See the repository README for additional example commands and plotting options.