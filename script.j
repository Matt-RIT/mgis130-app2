// DATA LAYER: Stores and manages the raw application state for bill amount, party size, tip percentage, and rounding rules.
const appData = {
    billAmount: 0,
    tipPercentage: 18,
    partySize: 2,
    roundUp: false
};

// DATA LAYER: Updates a specific state property with validated raw inputs.
function setAppDataValue(key, value) {
    if (appData.hasOwnProperty(key)) {
        appData[key] = value;
    }
}

// DATA LAYER: Resets all state variables back to initial default baseline values.
function resetAppDataToDefaults() {
    appData.billAmount = 0;
    appData.tipPercentage = 18;
    appData.partySize = 2;
    appData.roundUp = false;
}



// LOGIC LAYER: Computes exact tip totals, individual splits, and optional dollar rounding adjustments.
function calculateTipAndSplitLogic(data) {
    const bill = Math.max(0, parseFloat(data.billAmount) || 0);
    const party = Math.max(1, parseInt(data.partySize) || 1);
    const tipPct = Math.max(0, parseFloat(data.tipPercentage) || 0);

    const totalTip = bill * (tipPct / 100);
    const grandTotal = bill + totalTip;
    
    let billPerPerson = bill / party;
    let tipPerPerson = totalTip / party;
    let totalPerPerson = grandTotal / party;

    // Optional smart round-up feature to clean whole dollar values
    if (data.roundUp && totalPerPerson > 0) {
        totalPerPerson = Math.ceil(totalPerPerson);
    }

    return {
        billAmount: bill,
        partySize: party,
        tipPercentage: tipPct,
        totalTip: totalTip,
        grandTotal: grandTotal,
        billPerPerson: billPerPerson,
        tipPerPerson: tipPerPerson,
        totalPerPerson: totalPerPerson
    };
}

// LOGIC LAYER: Analyzes bill size and tip ratio to construct smart AI insight recommendation summaries.
function generateAiInsightLogic(results) {
    if (results.billAmount <= 0) {
        return "Enter a bill amount above to get started with instant group calculations.";
    }

    const { billAmount, partySize, tipPercentage, totalPerPerson } = results;

    if (tipPercentage < 15) {
        return `A ${tipPercentage}% tip is on the lower side. Consider raising to 18% for standard dining service.`;
    } else if (tipPercentage >= 20) {
        return `Generous ${tipPercentage}% tip! Each person's share of $${totalPerPerson.toFixed(2)} ensures high appreciation for the staff.`;
    } else if (partySize >= 6) {
        return `For large parties (${partySize} people), splitting $${totalPerPerson.toFixed(2)} equally keeps payments seamless.`;
    } else {
        return `Standard ${tipPercentage}% tip balance selected. Total comes out to $${totalPerPerson.toFixed(2)} per person.`;
    }
}



// DISPLAY LAYER: Reads state and logic calculations to update screen values, text fields, and UI badges.
function renderScreenDisplay() {
    const results = calculateTipAndSplitLogic(appData);
    const aiInsight = generateAiInsightLogic(results);

    // Update form badges and input displays
    document.getElementById('tip-badge').innerText = `${appData.tipPercentage}%`;
    document.getElementById('party-badge').innerText = `${appData.partySize} ${appData.partySize === 1 ? 'Person' : 'People'}`;
    document.getElementById('party-count').innerText = appData.partySize;

    // Update screen result values
    document.getElementById('display-person-total').innerText = `$${results.totalPerPerson.toFixed(2)}`;
    document.getElementById('display-person-bill').innerText = `$${results.billPerPerson.toFixed(2)}`;
    document.getElementById('display-person-tip').innerText = `$${results.tipPerPerson.toFixed(2)}`;
    document.getElementById('display-total-tip').innerText = `$${results.totalTip.toFixed(2)}`;
    document.getElementById('display-grand-total').innerText = `$${results.grandTotal.toFixed(2)}`;

    // Update AI Insight card
    document.getElementById('ai-insight-text').innerText = aiInsight;
}

// DISPLAY LAYER: Displays temporary toast notifications for user interactions like clipboard copy.
function showToastNotificationDisplay(messageText) {
    const toast = document.getElementById('toast-message');
    toast.innerText = messageText;
    toast.classList.add('show');
    setTimeout(() => {
        toast.classList.remove('show');
    }, 2500);
}

// DISPLAY LAYER: Resets all UI form elements back to baseline visually.
function resetScreenDisplay() {
    resetAppDataToDefaults();
    document.getElementById('bill-amount').value = '';
    document.getElementById('round-up-toggle').checked = false;
    
    // Reset active chip button
    document.querySelectorAll('.chip-btn').forEach(btn => {
        if (btn.dataset.tip === "18") {
            btn.classList.add('active');
        } else {
            btn.classList.remove('active');
        }
    });

    renderScreenDisplay();
    showToastNotificationDisplay("Cleared all values!");
}



document.addEventListener('DOMContentLoaded', () => {
    const billInput = document.getElementById('bill-amount');
    const chipButtons = document.querySelectorAll('.chip-btn');
    const partyMinusBtn = document.getElementById('party-minus');
    const partyPlusBtn = document.getElementById('party-plus');
    const roundUpToggle = document.getElementById('round-up-toggle');
    const copyBtn = document.getElementById('copy-summary-btn');
    const resetBtn = document.getElementById('reset-btn');

    // Bill input listener
    billInput.addEventListener('input', (e) => {
        setAppDataValue('billAmount', e.target.value);
        renderScreenDisplay();
    });

    // Tip preset chip buttons listener
    chipButtons.forEach(btn => {
        btn.addEventListener('click', () => {
            chipButtons.forEach(b => b.classList.remove('active'));
            btn.classList.add('active');
            setAppDataValue('tipPercentage', parseFloat(btn.dataset.tip));
            renderScreenDisplay();
        });
    });

    // Party size decrement listener
    partyMinusBtn.addEventListener('click', () => {
        if (appData.partySize > 1) {
            setAppDataValue('partySize', appData.partySize - 1);
            renderScreenDisplay();
        }
    });

    // Party size increment listener
    partyPlusBtn.addEventListener('click', () => {
        setAppDataValue('partySize', appData.partySize + 1);
        renderScreenDisplay();
    });

    // Round up toggle listener
    roundUpToggle.addEventListener('change', (e) => {
        setAppDataValue('roundUp', e.target.checked);
        renderScreenDisplay();
    });

    // Copy formatted summary listener
    copyBtn.addEventListener('click', () => {
        const results = calculateTipAndSplitLogic(appData);
        if (results.billAmount <= 0) {
            showToastNotificationDisplay("Please enter a bill amount first!");
            return;
        }

        const summaryText = `🧾 Tip Split AI Summary:\n` +
            `• Bill Total: $${results.billAmount.toFixed(2)}\n` +
            `• Tip (${results.tipPercentage}%): $${results.totalTip.toFixed(2)}\n` +
            `• Grand Total: $${results.grandTotal.toFixed(2)}\n` +
            `• Party Size: ${results.partySize} ${results.partySize === 1 ? 'person' : 'people'}\n` +
            `👉 Each Person Owes: $${results.totalPerPerson.toFixed(2)}`;

        // Clipboard copy mechanism
        if (navigator.clipboard && navigator.clipboard.writeText) {
            navigator.clipboard.writeText(summaryText)
                .then(() => showToastNotificationDisplay("Summary copied to clipboard!"))
                .catch(() => fallbackCopyTextDisplay(summaryText));
        } else {
            fallbackCopyTextDisplay(summaryText);
        }
    });

    // Fallback copy method
    function fallbackCopyTextDisplay(text) {
        const textArea = document.createElement("textarea");
        textArea.value = text;
        document.body.appendChild(textArea);
        textArea.select();
        document.execCommand('copy');
        document.body.removeChild(textArea);
        showToastNotificationDisplay("Summary copied to clipboard!");
    }

    // Reset button listener
    resetBtn.addEventListener('click', resetScreenDisplay);

    // Initial render call
    renderScreenDisplay();
});
</script>
</body>
</html>
