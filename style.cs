        :root {
            --bg-gradient: linear-gradient(135deg, #0f172a 0%, #1e1b4b 50%, #0f172a 100%);
            --card-bg: rgba(30, 41, 59, 0.7);
            --card-border: rgba(255, 255, 255, 0.1);
            --accent-primary: #818cf8;
            --accent-secondary: #c084fc;
            --accent-gradient: linear-gradient(135deg, #6366f1 0%, #a855f7 100%);
            --accent-glow: rgba(99, 102, 241, 0.35);
            --text-main: #f8fafc;
            --text-muted: #94a3b8;
            --input-bg: rgba(15, 23, 42, 0.6);
            --input-border: #334155;
            --input-focus: #818cf8;
            --success-color: #34d399;
            --radius-lg: 18px;
            --radius-md: 12px;
            --radius-sm: 8px;
            --font-family: -apple-system, BlinkMacSystemFont, "Segoe UI", Roboto, Helvetica, Arial, sans-serif;
        }

        * {
            box-sizing: border-box;
            margin: 0;
            padding: 0;
            font-family: var(--font-family);
            -webkit-tap-highlight-color: transparent;
        }

        body {
            background: var(--bg-gradient);
            color: var(--text-main);
            min-height: 100vh;
            display: flex;
            justify-content: center;
            align-items: center;
            padding: 16px;
        }

        .app-container {
            width: 100%;
            max-width: 480px;
            background: var(--card-bg);
            backdrop-filter: blur(16px);
            -webkit-backdrop-filter: blur(16px);
            border: 1px solid var(--card-border);
            border-radius: var(--radius-lg);
            padding: 24px;
            box-shadow: 0 20px 40px rgba(0, 0, 0, 0.4), 0 0 30px rgba(99, 102, 241, 0.15);
        }

        .header {
            text-align: center;
            margin-bottom: 24px;
        }

        .brand-badge {
            display: inline-flex;
            align-items: center;
            gap: 6px;
            padding: 4px 12px;
            background: rgba(99, 102, 241, 0.15);
            border: 1px solid rgba(129, 140, 248, 0.3);
            border-radius: 20px;
            font-size: 0.75rem;
            font-weight: 600;
            color: var(--accent-primary);
            text-transform: uppercase;
            letter-spacing: 0.8px;
            margin-bottom: 8px;
        }

        .header h1 {
            font-size: 1.75rem;
            font-weight: 800;
            background: linear-gradient(135deg, #ffffff 0%, #cbd5e1 100%);
            -webkit-background-clip: text;
            -webkit-text-fill-color: transparent;
            letter-spacing: -0.5px;
        }

        .header p {
            font-size: 0.875rem;
            color: var(--text-muted);
            margin-top: 4px;
        }

        .form-group {
            margin-bottom: 20px;
        }

        .label-row {
            display: flex;
            justify-content: space-between;
            align-items: center;
            margin-bottom: 8px;
        }

        label {
            font-size: 0.875rem;
            font-weight: 600;
            color: #e2e8f0;
        }

        .value-badge {
            font-size: 0.875rem;
            font-weight: 700;
            color: var(--accent-primary);
        }

        .input-wrapper {
            position: relative;
            display: flex;
            align-items: center;
        }

        .currency-symbol {
            position: absolute;
            left: 14px;
            font-size: 1.1rem;
            font-weight: 600;
            color: var(--text-muted);
        }

        input[type="number"] {
            width: 100%;
            padding: 14px 14px 14px 32px;
            background: var(--input-bg);
            border: 1px solid var(--input-border);
            border-radius: var(--radius-md);
            color: var(--text-main);
            font-size: 1.125rem;
            font-weight: 600;
            outline: none;
            transition: all 0.2s ease;
        }

        input[type="number"]:focus {
            border-color: var(--input-focus);
            box-shadow: 0 0 0 3px rgba(129, 140, 248, 0.2);
        }

        .chip-grid {
            display: grid;
            grid-template-columns: repeat(5, 1fr);
            gap: 8px;
            margin-top: 8px;
        }

        .chip-btn {
            background: var(--input-bg);
            border: 1px solid var(--input-border);
            border-radius: var(--radius-sm);
            color: var(--text-main);
            padding: 10px 0;
            font-size: 0.875rem;
            font-weight: 600;
            cursor: pointer;
            transition: all 0.2s ease;
        }

        .chip-btn:hover {
            border-color: var(--accent-primary);
        }

        .chip-btn.active {
            background: var(--accent-gradient);
            border-color: transparent;
            color: #ffffff;
            box-shadow: 0 4px 12px var(--accent-glow);
        }

        .stepper-container {
            display: flex;
            align-items: center;
            background: var(--input-bg);
            border: 1px solid var(--input-border);
            border-radius: var(--radius-md);
            overflow: hidden;
        }

        .stepper-btn {
            width: 52px;
            height: 48px;
            background: transparent;
            border: none;
            color: var(--text-main);
            font-size: 1.25rem;
            font-weight: 700;
            cursor: pointer;
            transition: background 0.2s ease;
            display: flex;
            align-items: center;
            justify-content: center;
        }

        .stepper-btn:active {
            background: rgba(255, 255, 255, 0.1);
        }

        .stepper-value {
            flex: 1;
            text-align: center;
            font-size: 1.125rem;
            font-weight: 700;
            color: var(--text-main);
        }

        .toggle-row {
            display: flex;
            justify-content: space-between;
            align-items: center;
            padding: 12px 14px;
            background: var(--input-bg);
            border: 1px solid var(--input-border);
            border-radius: var(--radius-md);
        }

        .toggle-label {
            display: flex;
            flex-direction: column;
        }

        .toggle-title {
            font-size: 0.875rem;
            font-weight: 600;
        }

        .toggle-subtitle {
            font-size: 0.75rem;
            color: var(--text-muted);
        }

        .switch {
            position: relative;
            display: inline-block;
            width: 44px;
            height: 24px;
        }

        .switch input {
            opacity: 0;
            width: 0;
            height: 0;
        }

        .slider {
            position: absolute;
            cursor: pointer;
            top: 0;
            left: 0;
            right: 0;
            bottom: 0;
            background-color: #334155;
            transition: .3s;
            border-radius: 24px;
        }

        .slider:before {
            position: absolute;
            content: "";
            height: 18px;
            width: 18px;
            left: 3px;
            bottom: 3px;
            background-color: white;
            transition: .3s;
            border-radius: 50%;
        }

        input:checked + .slider {
            background-color: #6366f1;
        }

        input:checked + .slider:before {
            transform: translateX(20px);
        }

        .results-card {
            background: linear-gradient(135deg, rgba(99, 102, 241, 0.2) 0%, rgba(168, 85, 247, 0.15) 100%);
            border: 1px solid rgba(129, 140, 248, 0.3);
            border-radius: var(--radius-md);
            padding: 20px;
            margin-top: 24px;
            text-align: center;
            position: relative;
            overflow: hidden;
        }

        .results-hero-label {
            font-size: 0.85rem;
            text-transform: uppercase;
            letter-spacing: 1px;
            color: #cbd5e1;
            font-weight: 600;
        }

        .results-hero-value {
            font-size: 2.75rem;
            font-weight: 900;
            color: #ffffff;
            margin: 6px 0 16px 0;
            letter-spacing: -1px;
            text-shadow: 0 4px 12px rgba(0,0,0,0.3);
        }

        .breakdown-grid {
            display: grid;
            grid-template-columns: 1fr 1fr;
            gap: 12px;
            padding-top: 14px;
            border-top: 1px solid rgba(255, 255, 255, 0.1);
        }

        .breakdown-item {
            text-align: left;
            background: rgba(15, 23, 42, 0.4);
            padding: 10px 12px;
            border-radius: var(--radius-sm);
        }

        .breakdown-label {
            font-size: 0.75rem;
            color: var(--text-muted);
            margin-bottom: 2px;
        }

        .breakdown-val {
            font-size: 1rem;
            font-weight: 700;
            color: #f1f5f9;
        }

        .ai-recommendation-box {
            margin-top: 16px;
            background: rgba(15, 23, 42, 0.6);
            border-left: 3px solid var(--accent-secondary);
            border-radius: var(--radius-sm);
            padding: 12px;
            text-align: left;
            font-size: 0.8125rem;
            line-height: 1.4;
            color: #e2e8f0;
        }

        .ai-recommendation-title {
            font-weight: 700;
            color: var(--accent-secondary);
            margin-bottom: 4px;
            display: flex;
            align-items: center;
            gap: 6px;
        }

        .action-btn-row {
            display: flex;
            gap: 10px;
            margin-top: 20px;
        }

        .btn-primary {
            flex: 1;
            background: var(--accent-gradient);
            border: none;
            color: #ffffff;
            padding: 14px;
            border-radius: var(--radius-md);
            font-size: 0.95rem;
            font-weight: 700;
            cursor: pointer;
            transition: transform 0.15s ease, box-shadow 0.2s ease;
            box-shadow: 0 4px 16px var(--accent-glow);
            display: flex;
            align-items: center;
            justify-content: center;
            gap: 8px;
        }

        .btn-primary:active {
            transform: scale(0.98);
        }

        .btn-secondary {
            background: var(--input-bg);
            border: 1px solid var(--input-border);
            color: var(--text-muted);
            padding: 14px;
            border-radius: var(--radius-md);
            font-size: 0.95rem;
            font-weight: 600;
            cursor: pointer;
            transition: background 0.2s ease;
        }

        .btn-secondary:hover {
            color: var(--text-main);
            border-color: #475569;
        }

        .toast {
            position: fixed;
            bottom: 24px;
            left: 50%;
            transform: translateX(-50%) translateY(100px);
            background: #1e293b;
            color: var(--success-color);
            border: 1px solid var(--success-color);
            padding: 12px 20px;
            border-radius: 30px;
            font-size: 0.875rem;
            font-weight: 600;
            box-shadow: 0 10px 25px rgba(0,0,0,0.5);
            opacity: 0;
            transition: all 0.3s cubic-bezier(0.175, 0.885, 0.32, 1.275);
            z-index: 1000;
            pointer-events: none;
        }

        .toast.show {
            transform: translateX(-50%) translateY(0);
            opacity: 1;
        }
    </style>
</head>
<body>

<div class="app-container">
    <div class="header">
        <div class="brand-badge">✨ AI Powered</div>
        <h1>Tip Split AI</h1>
        <p>Intelligent bill splitting for groups</p>
    </div>

    <!-- Input Form controls -->
    <div class="form-group">
        <div class="label-row">
            <label for="bill-amount">Total Bill Amount</label>
        </div>
        <div class="input-wrapper">
            <span class="currency-symbol">$</span>
            <input type="number" id="bill-amount" placeholder="0.00" step="0.01" min="0" inputmode="decimal">
        </div>
    </div>

    <div class="form-group">
        <div class="label-row">
            <label>Tip Percentage</label>
            <span class="value-badge" id="tip-badge">18%</span>
        </div>
        <div class="chip-grid">
            <button class="chip-btn" data-tip="10">10%</button>
            <button class="chip-btn" data-tip="15">15%</button>
            <button class="chip-btn active" data-tip="18">18%</button>
            <button class="chip-btn" data-tip="20">20%</button>
            <button class="chip-btn" data-tip="25">25%</button>
        </div>
    </div>

    <div class="form-group">
        <div class="label-row">
            <label>Party Size</label>
            <span class="value-badge" id="party-badge">2 People</span>
        </div>
        <div class="stepper-container">
            <button class="stepper-btn" id="party-minus" aria-label="Decrease party size">−</button>
            <div class="stepper-value" id="party-count">2</div>
            <button class="stepper-btn" id="party-plus" aria-label="Increase party size">+</button>
        </div>
    </div>

    <div class="form-group">
        <div class="toggle-row">
            <div class="toggle-label">
                <span class="toggle-title">Round Up Shares</span>
                <span class="toggle-subtitle">Avoid loose change per person</span>
            </div>
            <label class="switch">
                <input type="checkbox" id="round-up-toggle">
                <span class="slider"></span>
            </label>
        </div>
    </div>

    <!-- Results Display -->
    <div class="results-card">
        <div class="results-hero-label">Each Person Owes</div>
        <div class="results-hero-value" id="display-person-total">$0.00</div>

        <div class="breakdown-grid">
            <div class="breakdown-item">
                <div class="breakdown-label">Bill Per Person</div>
                <div class="breakdown-val" id="display-person-bill">$0.00</div>
            </div>
            <div class="breakdown-item">
                <div class="breakdown-label">Tip Per Person</div>
                <div class="breakdown-val" id="display-person-tip">$0.00</div>
            </div>
            <div class="breakdown-item">
                <div class="breakdown-label">Total Tip</div>
                <div class="breakdown-val" id="display-total-tip">$0.00</div>
            </div>
            <div class="breakdown-item">
                <div class="breakdown-label">Grand Total</div>
                <div class="breakdown-val" id="display-grand-total">$0.00</div>
            </div>
        </div>

        <div class="ai-recommendation-box">
            <div class="ai-recommendation-title">💡 Smart AI Insight</div>
            <div id="ai-insight-text">Enter a bill amount to view smart tipping calculations and recommendations.</div>
        </div>
    </div>

    <div class="action-btn-row">
        <button class="btn-primary" id="copy-summary-btn">📋 Copy Summary</button>
        <button class="btn-secondary" id="reset-btn">Reset</button>
    </div>
</div>

<div class="toast" id="toast-message">Summary copied to clipboard!</div>
