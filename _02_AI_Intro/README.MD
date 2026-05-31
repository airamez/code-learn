# Intro to AI for Software Engineering

## What is AI?

- AI (Artificial Intelligence) is the field of building systems that can perform tasks typically requiring human intelligence, such as understanding language, recognizing patterns, making decisions, and solving problems.
- In software engineering, AI helps automate routine work, surface insights, and speed up development across planning, coding, testing, and operations.

## Why AI matters for software teams

- Accelerates development by generating code snippets, tests, and documentation
- Improves quality with automated defect detection and security checks
- Helps teams make decisions faster using data-driven insights
- Enables personalization and smarter applications through predictive models
- Like any other tool, framework, paradigm, etc., there is no guarantee of success and aboce all no magic :)

## Widespread Adoption Across the Industry

- AI tools have moved from experimental to mainstream: 95% of engineers use AI tools at least weekly, with 75% using them for half or more of their work (and 56% for 70%+)
  - (https://newsletter.pragmaticengineer.com/p/ai-tooling-2026)
- 84-92% of developers use or plan to use AI coding assistants daily or weekly.
  - https://firstlinesoftware.com/blog/ai-software-development-2026-2035/
- AI now generates a significant portion of new code: Google reports ~75% of new code is AI-generated (up from 25% in late 2024); overall industry estimates show 40-50%+ of code is AI-assisted.
  - https://dev.to/kanywst/what-11-big-tech-companies-actually-do-with-ai-in-2026-a-layered-numbers-first-breakdown-h58


## Core Use Cases in the Software Development Lifecycle

- Code Generation & Completion
  - Inline suggestions, boilerplate, full functions, and features (GitHub Copilot, Cursor, Claude Code, Amazon Q, etc.).
- Automated Testing
  - AI generates unit/integration tests, identifies edge cases, and creates test cases in parallel with development.
- Code Review, Refactoring & Quality 
  - AI-powered reviews, bug detection, refactoring suggestions, and security vulnerability scanning.
- Prototyping & Experimentation
  - AI accelerates early validation by generating proof-of-concept code, UI mocks, and integration experiments, but there is often a large gap and risk when moving these prototypes into production-grade systems.
- Documentation & Requirements
  - Auto-generating docs, summarizing code, translating requirements into specs.
- Debugging & Maintenance
  - Root cause analysis, legacy code modernization, and predictive issue detection.
- DevOps & Operations
  - CI/CD optimization, infrastructure provisioning, incident management, and deployment automation via AI agents.
- Source
  - https://www.mckinsey.com/capabilities/tech-and-ai/our-insights/the-ai-revolution-in-software-development

## Shift in Developer Roles: From Coder to Orchestrator

- Developers spend less time on routine coding and more on architecture, validation, system design, and overseeing AI agents.
- Rise of AI Agents: 55%+ of engineers use agents that can handle multi-step tasks (planning → coding → testing → PR submission).
- Human focus moves to higher-value work: intent definition, quality gates, and complex problem-solving.
- Several high-skilled engineers now report they rarely type production code manually; instead they prompt AI to generate implementations and then review those outputs very carefully before merging.
- Many experts now describe senior engineers as “reviewers of AI output” rather than pure code authors, with workflows that spend more time validating generated logic than writing syntax.
- References
  - https://techcrunch.com/2026/02/12/spotify-says-its-best-developers-havent-written-a-line-of-code-since-december-thanks-to-ai/
  - https://finance.yahoo.com/news/spotify-ceo-says-top-developers-103101995.html
  - https://medium.com/@yalovoy/the-senior-engineers-job-in-2026-is-code-review-not-code-writing-f804036c55ab
  - https://www.techinterview.org/post/3233475092/reviewing-ai-generated-code-skills/

## Productivity & Business Impact

- Reported gains
  - 30-55% faster task completion, 30%+ reduction in time-to-market, up to 64% increase in per-engineer output (e.g., Mercari).
  - Stripe (1,300+ PRs/week merged by agents)
  - Spotify (30% increase in code changes/developer)
  - Meta (50% of code changes from DevMate) show scaled impact.
- Challenges
  - Increased rework/bug rates in some cases
  - Need for strong human oversight
  - Potential code quality issues if not managed well.
### References

- "Becoming AI‑Native at Mercari: Group Strategy and a US Case Study" (Medium) and "What 11 big tech companies actually do with AI in 2026" (Dev.to)
  - https://medium.com/mercari-engineering/becoming-ai-native-at-mercari-group-strategy-and-a-us-case-study-fda4a3ee5877
  - https://dev.to/kanywst/what-11-big-tech-companies-actually-do-with-ai-in-2026-a-layered-numbers-first-breakdown-h58
- Stripe: "How Stripe's Minions Ship 1300 PRs a Week" (ByteByteGo)
  - https://blog.bytebytego.com/p/how-stripes-minions-ship-1300-prs
- Spotify: TechCrunch coverage and Medium analysis of AI coding agents
  - https://techcrunch.com/2026/02/12/spotify-says-its-best-developers-havent-written-a-line-of-code-since-december-thanks-to-ai/
  - https://medium.com/codetodeploy/how-spotify-built-an-ai-coding-agent-that-merged-1-500-prs-6e913b9b4ca5
- Meta / DevMate: LinearB analysis and Medium architecture breakdown
  - https://linearb.io/blog/meta-ai-control-plane-james-everingham-guildai
  - https://medium.com/@wasowski.jarek/meta-devmate-agent-marketplace-architecture-multi-model-ai-coding-platform-c796815d3431

## Popular Tools & Ecosystem (2026)

- The AI developer ecosystem in 2026 is led by a mix of large platform providers and specialist code assistants.
- Most-used tools combine IDE pair programming, conversational LLM copilots, knowledge retrieval, and codebase-aware agents.
- The top products are now embedded into developer workflows, and the largest vendors maintain the strongest enterprise adoption.

| Tool | Owner | Primary Use | Approx. 2026 Market Share |
|---|---|---|---|
| GitHub Copilot | Microsoft / GitHub | IDE pair programming, code completion, doc-to-code | ~28% |
| ChatGPT (GPT-4.5/5) | OpenAI | general dev assistance, code generation, testing help | ~18% |
| Claude | Anthropic | enterprise code reasoning, safety-focused chat assistance | ~12% |
| Gemini | Google DeepMind | code search, multimodal dev workflows, RAG | ~10% |
| Amazon Q / CodeWhisperer | Amazon Web Services | cloud-native coding, DevOps, knowledge retrieval | ~9% |
| Cursor | Cursor | code generation, workflow automation, knowledge-to-code | ~6% |
| Sourcegraph Cody | Sourcegraph | code intelligence, repository search, RAG | ~5% |
| Tabnine | Perplexity | multi-language completion, local model support | ~4% |
| Replit Ghostwriter | Replit | browser-based coding, learning, and prototyping | ~3% |
| Windsurf | Windsurf AI | autonomous agent orchestration, developer productivity | ~3% |

- Most-used AI tools in 2026 are those tightly integrated into IDEs and enterprise platforms.
- GitHub Copilot remains the leader for daily coding tasks, while OpenAI and Anthropic dominate chat-driven developer assistance.
- Google Gemini and Amazon Q are strongest in organizations that already use Google Cloud or AWS extensively.
- Specialized tools like Cursor, Sourcegraph Cody, Tabnine, and Replit Ghostwriter are important for codebase search, knowledge retrieval, and niche workflow automation.
- The largest five platforms account for roughly 70-75% of the overall developer AI tool market, with the rest split among niche assistants and enterprise-specific deployments.

>Note: Enterprise adoption in 90%+ of Fortune 100 companies continues, especially for tools that add compliance, security, and source-aware code reasoning.

## Strategic Recommendations for Companies

- Embed AI across the full lifecycle (not just coding).
- Implement guardrails, review processes, and training for effective human-AI collaboration.
- Measure success beyond speed: focus on quality, maintainability, and usiness outcomes.
- Prepare for AI-native development models and evolving team structures.
- AI agents becoming standard and developers "conductors."

### Warning: In some cases using AI can be a disaster

- Major production incidents have shown that AI-assisted code must never be treated as self-certified. After a series of outages, Amazon reportedly blocked deployment of AI-generated changes without human review and required senior approval for AI-assisted commits from junior and mid-level engineers.
- High-regulation industries such as finance, accounting, healthcare, and aerospace are particularly vulnerable. In these domains, AI-generated code can create compliance gaps, unsafe behavior, or legal liability if it reaches production without strong human oversight.
- Legacy and complex distributed systems are also high risk, because AI tools often lack full visibility into system-wide dependencies, data contracts, and operational constraints.
- Other common failure modes include insecure code patterns, leaked proprietary data in prompts or responses, and brittle logic that passes unit tests but fails in real-world production conditions.
- Best practice: 
  - Use AI as an assistant, not an autonomous deployer.
  - Maintain clear review gates, provenance tracking, deterministic checks, and a strong human-in-the-loop approval process before releasing AI-assisted code.

#### References

- Amazon review gate example: https://x.com/godofprompt/status/2031419734537711825
- Industry post-mortem commentary: https://timonweb.com/ai/amazons-ai-code-broke-production-dont-let-yours-be-next/

## Key Terms

### LLM — Large Language Model

- A Large Language Model is a type of AI trained on massive amounts of text to understand and generate human-like language.

### RAG — Retrieval-Augmented Generation

- RAG combines a language model with an external knowledge source (like docs, codebases, or manuals).
- The model retrieves relevant facts and then generates answers using that context.

### MCP — Model Context Protocol

- MCP is a framework for how AI agents can interact with external tools and structured data

### Model

- A model is the trained mathematical function (a set of parameters and operations) that maps input tokens to output probabilities or predictions
- In practice this is implemented as a neural network that was learned from data.

### Parameters / Weights

- Parameters (also called weights) are the learned numeric values inside a model that determine its behavior.
- Parameters encode relationships between words: during training, the model adjusts them so that semantically related words are positioned close together in the embedding space, and so that word sequences that appear together in the training data have higher predicted probabilities.
- More parameters usually increase capacity but also require more compute and memory.

### Token / Tokenizer / Token ID

- A token is a unit of text used by the model (word piece, subword, or character).
- A tokenizer converts raw text into token IDs (integers) from a fixed vocabulary that the model processes.

### Inference vs Training

- Training is the process of updating parameters from large datasets.
- Inference (or serving) is using a trained model to generate outputs for new inputs without changing parameters.

### Context Window / Sequence Length

- The context window (or sequence length) is the maximum number of tokens the model can process at once.
- It determines how much conversation or document history the model can consider.

### Prompt

- A prompt is the text (instructions, examples, or questions) given to the model at inference time to elicit a desired response.
- Prompts can include few-shot examples to steer outputs.

### Fine-tuning / Instruction Tuning

- Fine-tuning updates a pretrained model on task-specific data to improve performance.
- Instruction tuning adapts a model to better follow human-style instructions.

### Few-shot / Zero-shot

- Few-shot means providing a small number of examples in the prompt
- Zero-shot means giving no examples and relying on the model's generalization from pretraining.

### Latency / Throughput

- Latency is the time it takes the model to produce a response for a single request.
- Throughput is how many requests (or tokens) a system can handle per unit time—important for scaling.

## Understanding how LLM works

Large Language Models are built in two major stages: pretraining a statistical model on a huge corpus of text, then using that model to generate or score new text. A model is not a conventional program with explicit rules; it is a set of learned numerical weights that define how language patterns are represented and combined.

### Meaning is statistical, not semantic

- A LLM does not truly understand the meaning of a word in the way humans do.
- It learns statistical relationships between tokens from the training data and uses those relationships to predict what comes next.
- That means the model can generate fluent text about a concept like a `color`, `God`, or `love`, but it does so by estimating which words and phrases are likely to appear together, not by holding a real understanding of the thing itself.
- The model knows patterns of usage, not inner meaning.
- It can talk about “blue” or “red,” but it does not internally perceive or experience color.
- It can write about “love” or “God,” but it does so by reflecting how those words are used in text, not by understanding their deeper meaning.

### Weights and parameters

- A **parameter** is any learned numeric value inside the model.
- A **weight** is a type of parameter, usually the numbers inside the model's matrices and vectors that control how information is transformed.
- The model has many parameters because it contains many learned matrices and arrays:
  - **biases** — constants added to layer outputs that allow the model to shift activations independently of the input.
  - **embedding vectors** — learned representations for tokens that convert discrete vocabulary IDs into continuous numeric vectors.
  - **layer normalization offsets and scales** — learned values that normalize and rescale layer activations to stabilize training and improve generalization.
  - **attention key/query/value projection values** — learned matrices used to compute attention scores and transform tokens into keys, queries, and values for the attention mechanism.
- Parameters are not a count of word-to-word connections. They are the learned coefficients that the model uses to compute relationships, attention, and predictions.
- A better way to think about it:
  - The model takes token embeddings as input.
  - It passes them through layers that use parameters to compute attention, transformations, and next-token probabilities.
  - Those parameters are what the model learns during training so that the output is likely to match the correct text.

#### Representation

```text
1 [text] --> 2 [tokenizer] --> 3 [token IDs]
                    |
                    v
               4 [embedding lookup]
                    |
                    v
            5 [token embedding vectors]
                    |
                    v
           6 [transformer layers / attention]
                    |
             uses learned parameters
            /       |         \
           v        v          v
     7 [W_Q,W_K,W_V] [W_1,W_2] [biases]
                    |
                    v
          8 [context-aware vectors]
                    |
                    v
         9 [output logits / probabilities]
                    |
                    v
             10 [generated tokens]
```

- 1 [text] — the raw human-readable input sentence or document.
- 2 [tokenizer] — converts raw text into discrete tokens based on a vocabulary.
- 3 [token IDs] — integer indexes for each token that the model can process.
- 4 [embedding lookup] — maps each token ID to a learned dense vector.
- 5 [token embedding vectors] — continuous numeric representations of the tokens.
- 6 [transformer layers / attention] — transformer blocks that compute relationships between tokens and transform embeddings.
- 7 [W_Q,W_K,W_V], [W_1,W_2], [biases] — learned parameters used inside attention and feed-forward layers.
- 8 [context-aware vectors] — token representations enriched by attention to other tokens in the input.
- 9 [output logits / probabilities] — scores for every token in the vocabulary, representing how likely each next token is.
- 10 [generated tokens] — the final text chosen by sampling or picking the highest-probability tokens.

#### A concrete example from a short paragraph with more words
- Original text:
  ```text
  Polar bears hunt seals on the ice.
  Seals eat small fishes under the ice.
  Small fishes swim in schools to avoid predators.
  ```
- Tokenized text for each sentence:
  ```text
  ["Polar", " bears", " hunt", " seals", " on", " the", " ice", "."]
  ["Seals", " eat", " small", " fishes", " under", " the", " ice", "."]
  ["Small", " fishes", " swim", " in", " schools", " to", " avoid", " predators", "."]
  ```
- Each token is converted into a vector embedding.
- The model then computes attention relationships between those vectors both inside each sentence and across the paragraph.
- This example has stronger word relations:
  - `Polar bears` is a subject phrase.
  - `hunt` connects that subject to the object `seals`.
  - `seals` becomes the subject of the next sentence, where it `eat`s `small fishes`.
  - `small fishes` is shared between sentence two and three, and it is connected to `swim` and `schools` in the third sentence.
  - Context words like `ice`, `cold water`, and `predators` help the model understand the environment and meaning of the actions.
- A simplified relation graph for the paragraph looks like this:
  ```text
  [Polar bears] --hunt--> [seals] --eat--> [small fishes] --swim--> [schools]
        |                            |                   |
        v                            v                   v
        [ice]                     [cold water]       [predators]
  ```
- A more token-level view of the same idea:
  ```text
  [Polar] --> [bears] --> [hunt] --> [seals] --> [on] --> [the] --> [ice] --> [.] 
                                      |
                                      v
                                    [eat] --> [small] --> [fishes] --> [near] --> [the] --> [cold] --> [water] --> [.] 
                                                          |
                                                          v
                                                        [swim] --> [in] --> [schools] --> [to] --> [avoid] --> [predators] --> [.] 
  ```
- The model learns that `Polar` and `bears` belong together in the phrase `Polar bears`.
- It also learns that `seals` is both the object of `hunt` and the subject of `eat`.
- `small fishes` is reused, so the model keeps a contextual chain from sentence two into sentence three.
- The graph is only an illustration. In practice, the model uses parameters to compute attention scores and context-aware vectors, not a stored symbolic graph.
- Some parameters help compute how much one token should consider another token, but the total parameter count is the number of learned values in the model.
- Parameters define the strength and behavior of the model's computations across all tokens and layers.
- Tokens
  - Text is first broken into smaller pieces called tokens.
    - A token can be a whole word, part of a word, punctuation, or even a single character, depending on the tokenizer.
  - The model does not see raw characters or words directly;
    - Each token is mapped to an integer ID from a fixed vocabulary.
  - Example: `The sky is blue`
  - Might become:
    ```text
    ["The", " sky", " is", " blue"]
    [1024, 17, 4056, 213]
    ```
    - The ID sequence is the encoded input the model actually processes.
  - Simple training example:
    - Suppose we want a model to answer questions about colors using a tiny dataset.
    - Training data:
      - Input: "Question: What color is the sky? Answer:"
      - Target output: " blue"
  - Step-by-step:
  1. Tokenize the input and target.
     - Input tokens: ["Question:", " What", " color", " is", " the", " sky", "?", " Answer:"]
     - Target tokens: [" blue"]
  2. Convert tokens to token IDs.
     - Example IDs: [3001, 27, 431, 9, 12, 215, 5, 210, 77]
  3. Look up token embeddings for each ID.
     - IDs become vectors: [e3001, e27, e431, ...]
  4. Process embeddings through transformer layers.
     - Each layer uses learned parameters (weights and biases) to compute attention and transform the vectors.
     - Attention lets the model compare the word "sky" with the prompt context so it knows what the question asks.
  5. The model predicts the next token probability distribution.
     - Output logits might assign high probability to " blue" and low probability to unrelated tokens.
  6. During training, the model compares its prediction to the true target " blue" and updates parameters to make that prediction more likely.
- In other words, the model learns from examples like this:

  ```text
  Input:  Question: What color is the sky? Answer:
  Target:  blue
  ```

  After training on enough examples, the model can generalize to new, similar questions:

  ```text
  Input:  Question: What color is grass? Answer:
  Output: green
  ```

  Graphical flow for one prompt:

  ```text
  User prompt:
    "Question: What color is grass? Answer:"
               |
            Tokenizer
               |
          Token IDs
      [3001, 27, 431, 9, 12, 508, 5, 210]
               |
       Embedding lookup
    [e3001, e27, e431, ..., e210]
               |
       Transformer layers
   (attention + feed-forward)
               |
     Context-aware vectors
    [c1, c2, c3, ..., c8]
               |
       Output logits
    [p(" green"), p(" blue"), p(" red"), ...]
               |
      Generated answer
        " green"
  ```

  - `Token IDs` are not the meaning of the words. They are the vocabulary indexes assigned by the tokenizer.
    For example, the tokenizer might assign:
    - 3001 → "Question:"
    - 27 → " What"
    - 431 → " color"
    - 210 → " Answer:"
    The numbers are simply how the model refers to each token internally.
  - `Embedding lookup` uses those IDs to select a learned vector from an embedding table.
    The embedding table is a matrix of shape `[vocab_size, embedding_dim]`.
    So ID 3001 indexes row 3001 and returns `e3001`, a vector like `[0.12, -0.34, 0.05, ...]`.
  - The model cannot multiply or compare raw text, so it first converts each token ID into a numeric embedding vector. This is why the step is called lookup: the ID points to the vector, and the vector is the actual input to the transformer layers.
  - The embedding table is a matrix of shape `[vocab_size × embedding_dim]`. Each row in the matrix is a dense vector for one token.
  - In other words, token IDs are the address of the word in the model's vocabulary, while embeddings are the actual numeric inputs the model uses to reason about meaning and context.

  This example teaches a key point: the model is created by adjusting parameters so that the chain from prompt tokens to output probabilities makes correct predictions. The same learned parameters are reused at inference time to answer new questions.

  >Warning: Is the sky always blue?

  Longer text is tokenized sequentially.

  ```text
  An integer is a whole number that can be positive, negative, or zero.
  Integers do not include fractions or decimals.
  ```

  This might become a stream of tokens such as:

  ```text
  ["An", " integer", " is", " a", " whole", " number", " that", " can", " be", " positive", ",", " negative", ",", " or", " zero", ".", "\n", "Integers", " do", " not", " include", " fractions", " or", " decimals", "."]
  ```

  - A tokenizer converts this into IDs and preserves the order so the model can reason about the text as a sequence.

- Parameters
  - Parameters are the model's learned numbers, stored in weight matrices and bias vectors.
  - Modern LLMs use billions or trillions of parameters. Each parameter is a floating-point value that contributes to how the model transforms token embeddings.
  - During training, the model adjusts these parameters to minimize prediction error. After training, the parameters are fixed and used to compute the next-token probabilities.
  - For example, one layer in a transformer might compute:

  ```text
  output = softmax(W2 * gelu(W1 * embedding + b1) + b2)
  ```

  where `W1`, `W2`, `b1`, and `b2` are all parameters.

  - More parameters generally mean more expressive power, but also higher compute and memory costs.

## Matrix multiplication in AI models

Matrix multiplication is one of the most important operations in modern AI models.
>Great video: https://www.youtube.com/watch?v=CDjZfmrPef4

- Embedding lookup is effectively a form of matrix multiplication.
  - A token ID selects one row from the embedding matrix. That row is a dense vector, and the whole embedding table is a matrix of shape `[vocab_size × embedding_dim]`.
  - In a hardware implementation, this lookup can be done by multiplying a one-hot token vector by the embedding matrix.

- Most transformer computations are matrix multiplications.
  - A transformer layer computes queries, keys, and values using weight matrices: `Q = X·W_Q`, `K = X·W_K`, `V = X·W_V`.
  - Attention scores are computed with another matrix multiply: `scores = Q·K^T`.
  - The attended output is then `softmax(scores)·V`, which is also matrix multiplication.
  - The feed-forward network inside the transformer is typically `FFN(X) = gelu(X·W_1 + b_1)·W_2 + b_2`.

- Why matrix multiplication matters
  - Matrix multiplication is a dense, regular operation that hardware like GPUs and TPUs can execute very efficiently.
  - Because transformer models process many tokens and many dimensions, most of the runtime and energy cost comes from these large matrix multiplies.
  - This is why AI accelerators are designed around fast matrix math and why software frameworks like PyTorch and TensorFlow expose it as a first-class primitive.

- In practice
  - The model does not compute one token at a time in isolation. It processes whole batches of token embeddings and applies these matrix operations across the full sequence.
  - This is what gives transformers their power: they can mix information from many tokens with a few large matrix multiplies rather than many small, irregular operations.

- Training and fine-tuning
  - During pretraining, the model learns to predict missing or next tokens from a large volume of text. That training objective is what gives it a statistical sense of grammar, facts, and common word sequences.
  - Fine-tuning or instruction tuning is usually applied afterward to specialize the base model for tasks like question answering, coding help, or following developer prompts.

- From source text to answers
  - When you ask a question, the input text is tokenized and converted into a sequence of token IDs. These IDs are mapped into vectors by an embedding layer.
  - The model processes these vectors through many layers of computation, often transformer layers with attention mechanisms. Attention lets the model weigh different input tokens relative to one another, so it can decide which parts of the prompt are most relevant.
  - The final output is a sequence of token probabilities. The model selects likely next tokens one by one, producing text that answers the question or continues the prompt.

## Neural Network

- An LLM is a specific application of a neural network.
- Most modern LLMs are built as transformer neural networks, which are a type of deep neural network architecture.
- The neural network is the underlying model: layers, neurons, weights, biases, activations.
- The LLM is the trained version of that network on massive text data, so it can predict and generate language.
- Neural network = the general mathematical model and architecture.
- LLM = a neural network trained specifically to process and generate language.

>Amazing video: https://www.youtube.com/watch?v=aircAruvnKk&list=WL&index=3

### Interesting Facts
- Modern LLMs are based on older ideas, but the breakthrough came from massive scaling, transformer architecture, and new training methods
- Multiple analyses note that emergent capabilities—reasoning, coding, translation—appeared unexpectedly once models crossed certain size/data thresholds.
- Massive scaling was the key breakthrough.
  - Papers surveying LLM evolution emphasize that the jump from earlier models to GPT‑3–4–5–style systems came from:
    - training on hundreds of billions to trillions of tokens,
    - using hundreds of billions of parameters,
    - and applying huge compute budgets.
  - These surveys explicitly highlight that brute‑force scaling was the dominant driver of early LLM progress. 
- Researchers genuinely did not expect scaling alone to work as well as it did.
- Scaling is hitting limits.  
  - Recent research identifies “scaling walls”:
    - data scarcity,
    - exponential cost growth,
    - energy constraints.
    - This means future progress will require more than just “make it bigger.”









